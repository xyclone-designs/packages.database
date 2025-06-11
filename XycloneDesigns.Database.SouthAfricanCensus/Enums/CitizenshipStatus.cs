using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum CitizenshipStatus 
	{
		SouthAfricaOnly,
		SouthAfricaAndAnotherCountry,
		AnotherCountryOnly,
	}

	public static class CitizenshipStatussExtensions
	{
		public static CitizenshipStatus? FromInt(this CitizenshipStatus _, int? value, Years? year, out NotAvailables? notavailable)
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
				(1, Years._1996) => CitizenshipStatus.SouthAfricaOnly,
				(2, Years._1996) => CitizenshipStatus.SouthAfricaAndAnotherCountry,
				(3, Years._1996) => CitizenshipStatus.AnotherCountryOnly,

				(1, _) => CitizenshipStatus.SouthAfricaOnly,
				(2, _) => CitizenshipStatus.SouthAfricaAndAnotherCountry,
				(3, _) => CitizenshipStatus.AnotherCountryOnly,

				_ => notavailable is null
					? new CitizenshipStatus?()
					: throw new ArgumentException(string.Format("CitizenshipStatus for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}