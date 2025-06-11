using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum MaritalStatuses
	{
		NeverMarried,
		MarriedCivilReligious,
		MarriedTraditional,
		LivingTogether,
		Widowed,
		DivorcedSeparated,
	}

	public static class MaritalStatusessExtensions
	{
		public static MaritalStatuses? FromInt(this MaritalStatuses _, int? value, Years? year, out NotAvailables? notavailable)
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
				(1, Years._1996) => MaritalStatuses.NeverMarried,
				(2, Years._1996) => MaritalStatuses.MarriedCivilReligious,
				(3, Years._1996) => MaritalStatuses.MarriedTraditional,
				(4, Years._1996) => MaritalStatuses.LivingTogether,
				(5, Years._1996) => MaritalStatuses.Widowed,
				(6, Years._1996) => MaritalStatuses.DivorcedSeparated,

				(1, _) => MaritalStatuses.NeverMarried,
				(2, _) => MaritalStatuses.MarriedCivilReligious,
				(3, _) => MaritalStatuses.MarriedTraditional,
				(4, _) => MaritalStatuses.LivingTogether,
				(5, _) => MaritalStatuses.Widowed,
				(6, _) => MaritalStatuses.DivorcedSeparated,

				_ => notavailable is null
					? new MaritalStatuses?()
					: throw new ArgumentException(string.Format("MaritalStatuses for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}