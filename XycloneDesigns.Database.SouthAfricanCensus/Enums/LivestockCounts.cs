using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum LivestockCounts
	{
		_000,
		_001To010,
		_010To100,
		_100OrMore,
	}

	public static class LivestockCountsExtensions
	{
		public static LivestockCounts? FromInt(this LivestockCounts _, int value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._2011) => NotAvailables.Unspecified,

				_ => new NotAvailables?(),
			};

			return (value, year) switch
			{
				(1, Years._2011) => LivestockCounts._000,
				(2, Years._2011) => LivestockCounts._001To010,
				(3, Years._2011) => LivestockCounts._010To100,
				(4, Years._2011) => LivestockCounts._100OrMore,

				(1, _) => LivestockCounts._000,
				(2, _) => LivestockCounts._001To010,
				(3, _) => LivestockCounts._010To100,
				(4, _) => LivestockCounts._100OrMore,

				_ => notavailable is null
					? new LivestockCounts?()
					: throw new ArgumentException(string.Format("LivestockCounts for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}