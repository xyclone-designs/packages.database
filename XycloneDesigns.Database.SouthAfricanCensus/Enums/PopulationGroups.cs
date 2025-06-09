using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum PopulationGroups
	{
		AfricanBlack,
		Coloured,
		IndianAsian,
		White,
	}

	public static class PopulationGroupssExtensions
	{
		public static PopulationGroups? FromInt(this PopulationGroups _, int value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,

				_ => new NotAvailables?(),
			};

			return (value, year) switch
			{
				(1, Years._1996) => PopulationGroups.AfricanBlack,
				(2, Years._1996) => PopulationGroups.Coloured,
				(3, Years._1996) => PopulationGroups.IndianAsian,
				(4, Years._1996) => PopulationGroups.White,

				(1, _) => PopulationGroups.AfricanBlack,
				(2, _) => PopulationGroups.Coloured,
				(3, _) => PopulationGroups.IndianAsian,
				(4, _) => PopulationGroups.White,

				_ => notavailable is null
					? new PopulationGroups?()
					: throw new ArgumentException(string.Format("PopulationGroup for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}