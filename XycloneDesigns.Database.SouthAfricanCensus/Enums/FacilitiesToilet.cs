using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum FacilitiesToilet
	{
		FlushOrChemicalToilet,
		PitLatrine,
		BucketLatrine,
		NoneOfTheAbove,
	}

	public static class FacilitiesToiletsExtensions
	{
		public static FacilitiesToilet? FromInt(this FacilitiesToilet _, int? value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.DummyHouseholds,

				_ => new NotAvailables?(),
			};

			if (value is null) return null;

			return (value.Value, year) switch
			{
				(1, Years._1996) => FacilitiesToilet.FlushOrChemicalToilet,
				(2, Years._1996) => FacilitiesToilet.PitLatrine,
				(3, Years._1996) => FacilitiesToilet.BucketLatrine,
				(4, Years._1996) => FacilitiesToilet.NoneOfTheAbove,

				(1, _) => FacilitiesToilet.FlushOrChemicalToilet,
				(2, _) => FacilitiesToilet.PitLatrine,
				(3, _) => FacilitiesToilet.BucketLatrine,
				(4, _) => FacilitiesToilet.NoneOfTheAbove,

				_ => notavailable is null
					? new FacilitiesToilet?()
					: throw new ArgumentException(string.Format("FacilitiesToilet for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}