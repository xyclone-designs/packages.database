using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum SourceOfWater
	{
		PipedWaterInDwelling,
		PipedWaterOnSite,
		PublicTap,
		WaterCarrierTanker,
		BoreholeRainWaterTankWell,
		DamRiverStreamSpring,
		Other,
	}

	public static class SourceOfWatersExtensions
	{
		public static SourceOfWater? FromInt(this SourceOfWater _, int? value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.DummyHouseholds,

				_ => new NotAvailables?(),
			};

			if (value is null) return null;

			return (value.Value, year) switch
			{
				(1, Years._1996) => SourceOfWater.PipedWaterInDwelling,
				(2, Years._1996) => SourceOfWater.PipedWaterOnSite,
				(3, Years._1996) => SourceOfWater.PublicTap,
				(4, Years._1996) => SourceOfWater.WaterCarrierTanker,
				(5, Years._1996) => SourceOfWater.BoreholeRainWaterTankWell,
				(6, Years._1996) => SourceOfWater.DamRiverStreamSpring,
				(7, Years._1996) => SourceOfWater.Other,

				(1, _) => SourceOfWater.PipedWaterInDwelling,
				(2, _) => SourceOfWater.PipedWaterOnSite,
				(3, _) => SourceOfWater.PublicTap,
				(4, _) => SourceOfWater.WaterCarrierTanker,
				(5, _) => SourceOfWater.BoreholeRainWaterTankWell,
				(6, _) => SourceOfWater.DamRiverStreamSpring,
				(7, _) => SourceOfWater.Other,

				_ => notavailable is null
					? new SourceOfWater?()
					: throw new ArgumentException(string.Format("Province for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}