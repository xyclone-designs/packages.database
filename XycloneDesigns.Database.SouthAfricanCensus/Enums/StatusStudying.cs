using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum StatusStudying
	{
		FullTime,
		PartTime,
		No,
	}

	public static class StatusStudyingsExtensions
	{
		public static StatusStudying? FromInt(this StatusStudying _, int value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,
				(7, Years._1996) => NotAvailables.AgedLessThan05,
				(8, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			return (value, year) switch
			{
				(1, Years._1996) => StatusStudying.FullTime,
				(2, Years._1996) => StatusStudying.PartTime,
				(3, Years._1996) => StatusStudying.No,

				(1, _) => StatusStudying.FullTime,
				(2, _) => StatusStudying.PartTime,
				(3, _) => StatusStudying.No,
				
				_ => notavailable is null
					? new StatusStudying?()
					: throw new ArgumentException(string.Format("Province for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}