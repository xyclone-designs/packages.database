using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum UsualResidence
	{
		NoUsualAddress,
		UsualResident,
		Visitor,
	}

	public static class UsualResidencesExtensions
	{
		public static UsualResidence? FromInt(this UsualResidence _, int value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,
				(8, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			return (value, year) switch
			{
				(1, Years._1996) => UsualResidence.UsualResident,
				(2, Years._1996) => UsualResidence.Visitor,
				(3, Years._1996) => UsualResidence.NoUsualAddress,

				(1, _) => UsualResidence.UsualResident,
				(2, _) => UsualResidence.Visitor,
				(3, _) => UsualResidence.NoUsualAddress,

				_ => notavailable is null
					? new UsualResidence?()
					: throw new ArgumentException(string.Format("UsualResidence for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}