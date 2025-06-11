using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum Sexes
	{
		Male,
		Female,
	}

	public static class SexesExtensions
	{
		public static Sexes? FromInt(this Sexes _, int? value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,
				(8, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			if (value is null) return null;

			return (value.Value, year) switch
			{
				(1, _) => Sexes.Male,
				(2, _) => Sexes.Female,

				_ => notavailable is null
					? new Sexes?()
					: throw new ArgumentException(string.Format("Sexes for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}