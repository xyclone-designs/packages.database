using System;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum Provinces
	{
		EasternCape,
		FreeState,
		Gauteng,
		KwaZuluNatal, 
		Limpopo, 
		Mpumalanga,
		NorthernCape,
		NorthWest,
		WesternCape,
	}

	public static class ProvincessExtensions
	{
		public static Provinces FromInt(this Provinces _, int value, Years? year)
		{
			return (value, year) switch
			{
				(1, Years._1996) => Provinces.WesternCape,
				(2, Years._1996) => Provinces.EasternCape,
				(3, Years._1996) => Provinces.NorthernCape,
				(4, Years._1996) => Provinces.FreeState,
				(5, Years._1996) => Provinces.KwaZuluNatal,
				(6, Years._1996) => Provinces.NorthWest,
				(7, Years._1996) => Provinces.Gauteng,
				(8, Years._1996) => Provinces.Mpumalanga,
				(9, Years._1996) => Provinces.Limpopo,

				(1, _) => Provinces.EasternCape,
				(2, _) => Provinces.FreeState,
				(3, _) => Provinces.Gauteng,
				(4, _) => Provinces.KwaZuluNatal,
				(5, _) => Provinces.Limpopo,
				(6, _) => Provinces.Mpumalanga,
				(7, _) => Provinces.NorthernCape,
				(8, _) => Provinces.NorthWest,
				(9, _) => Provinces.WesternCape,

				_ => throw new ArgumentException(string.Format("Province for value '{0}' & year '{1}' not found", value, year))
			};
		}
		public static string AsString(this Provinces province)
		{
			return province switch
			{
				Provinces.EasternCape => "Eastern Cape",
				Provinces.FreeState => "Free State",
				Provinces.Gauteng => "Gauteng",
				Provinces.KwaZuluNatal => "KwaZulu-Natal",
				Provinces.Limpopo => "Limpopo",
				Provinces.Mpumalanga => "Mpumalanga",
				Provinces.NorthernCape => "Northern Cape",
				Provinces.NorthWest => "North West",
				Provinces.WesternCape => "Western Cape",

				_ => throw new ArgumentException(string.Format("Province for value '{0}' not found", province))
			};
		}
	}
}