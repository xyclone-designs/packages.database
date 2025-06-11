using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum SourceOfFuel
	{
		EectricityDirectFromAuthority,
		ElectricityFromOtherSource,
		Gas,
		Paraffin,
		Wood,
		Coal,
		AnimalDung,
		Other,
	}

	public static class SourceOfFuelsExtensions
	{
		public static SourceOfFuel? FromInt(this SourceOfFuel _, int? value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.DummyHouseholds,

				_ => new NotAvailables?(),
			};

			if (value is null) return null;

			return (value.Value, year) switch
			{
				(1, Years._1996) => SourceOfFuel.EectricityDirectFromAuthority,
				(2, Years._1996) => SourceOfFuel.ElectricityFromOtherSource,
				(3, Years._1996) => SourceOfFuel.Gas,
				(4, Years._1996) => SourceOfFuel.Paraffin,
				(5, Years._1996) => SourceOfFuel.Wood,
				(6, Years._1996) => SourceOfFuel.Coal,
				(8, Years._1996) => SourceOfFuel.AnimalDung,
				(0, Years._1996) => SourceOfFuel.Other,

				(1, _) => SourceOfFuel.EectricityDirectFromAuthority,
				(2, _) => SourceOfFuel.ElectricityFromOtherSource,
				(3, _) => SourceOfFuel.Gas,
				(4, _) => SourceOfFuel.Paraffin,
				(5, _) => SourceOfFuel.Wood,
				(6, _) => SourceOfFuel.Coal,
				(8, _) => SourceOfFuel.AnimalDung,
				(0, _) => SourceOfFuel.Other,

				_ => notavailable is null
					? new SourceOfFuel?()
					: throw new ArgumentException(string.Format("Province for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}