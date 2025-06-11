using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum IncomeLevelsMonthly
	{
		None,
		R1_R200,
		R201_R500,
		R501_R1000,
		R1001_R1500,
		R1501_R2500,
		R2501_R3500,
		R3501_R4500,
		R4501_R6000,
		R6001_R8000,
		R8001_R11000,
		R11001_R16000,
		R16001_R30000,
		R30001_OrMore,
	}

	public static class IncomeLevelsMonthlysExtensions
	{
		public static IncomeLevelsMonthly? FromInt(this IncomeLevelsMonthly _, int? value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(99, Years._1996) => NotAvailables.Unspecified,
				(98, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			if (value is null) return null;

			return (value.Value, year) switch
			{
				(01, Years._1996) => IncomeLevelsMonthly.None,
				(02, Years._1996) => IncomeLevelsMonthly.R1_R200,
				(03, Years._1996) => IncomeLevelsMonthly.R201_R500,
				(04, Years._1996) => IncomeLevelsMonthly.R501_R1000,
				(05, Years._1996) => IncomeLevelsMonthly.R1001_R1500,
				(06, Years._1996) => IncomeLevelsMonthly.R1501_R2500,
				(07, Years._1996) => IncomeLevelsMonthly.R2501_R3500,
				(08, Years._1996) => IncomeLevelsMonthly.R3501_R4500,
				(09, Years._1996) => IncomeLevelsMonthly.R4501_R6000,
				(10, Years._1996) => IncomeLevelsMonthly.R6001_R8000,
				(11, Years._1996) => IncomeLevelsMonthly.R8001_R11000,
				(12, Years._1996) => IncomeLevelsMonthly.R11001_R16000,
				(13, Years._1996) => IncomeLevelsMonthly.R16001_R30000,
				(14, Years._1996) => IncomeLevelsMonthly.R30001_OrMore,

				(01, _) => IncomeLevelsMonthly.None,
				(02, _) => IncomeLevelsMonthly.R1_R200,
				(03, _) => IncomeLevelsMonthly.R201_R500,
				(04, _) => IncomeLevelsMonthly.R501_R1000,
				(05, _) => IncomeLevelsMonthly.R1001_R1500,
				(06, _) => IncomeLevelsMonthly.R1501_R2500,
				(07, _) => IncomeLevelsMonthly.R2501_R3500,
				(08, _) => IncomeLevelsMonthly.R3501_R4500,
				(09, _) => IncomeLevelsMonthly.R4501_R6000,
				(10, _) => IncomeLevelsMonthly.R6001_R8000,
				(11, _) => IncomeLevelsMonthly.R8001_R11000,
				(12, _) => IncomeLevelsMonthly.R11001_R16000,
				(13, _) => IncomeLevelsMonthly.R16001_R30000,
				(14, _) => IncomeLevelsMonthly.R30001_OrMore,

				_ => notavailable is null
					? new IncomeLevelsMonthly?()
					: throw new ArgumentException(string.Format("Province for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}