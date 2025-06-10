
using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Tables
{
	[SQLite.Table(SQL.Table)]
    public class RecordsHouseholdAgricultural : RecordsHousehold
	{
		public new static class SQL 
		{
			public const string Table = "records_householdagricultural";
		}

		public int? LivestockProduction { get; set; }
		public int? Poultry { get; set; }
		public int? VegetableProduction { get; set; }
		public int? OtherCrops { get; set; }
		public int? FodderGrazingPastureGrassForAnimals { get; set; }
		public int? OtherAgriculturalActivies { get; set; }
		public int? NoAgriculturalActivies { get; set; }
		public string? Cattle 
		{ 
			get => _Cattle?.ToString(); 
			set => _Cattle= Uncertain.FromString<LivestockCounts>(value);
		}
		public string? Sheep 
		{ 
			get => _Sheep?.ToString(); 
			set => _Sheep = Uncertain.FromString<LivestockCounts>(value);
		}
		public string? Goats 
		{ 
			get => _Goats?.ToString(); 
			set => _Goats = Uncertain.FromString<LivestockCounts>(value);
		}
		public string? Pigs 
		{ 
			get => _Pigs?.ToString(); 
			set => _Pigs = Uncertain.FromString<LivestockCounts>(value);
		}
		public string? OtherLivestocks 
		{ 
			get => _OtherLivestocks?.ToString(); 
			set => _OtherLivestocks = Uncertain.FromString<LivestockCounts>(value);
		}
		public int? Farmland { get; set; }
		public int? BackyardOrSchool { get; set; }
		public int? CommunalOrTribalLand { get; set; }
		public int? OtherPlaceOfAgriculturalActivies { get; set; }

		private Uncertain<LivestockCounts>? _Cattle;
		private Uncertain<LivestockCounts>? _Sheep;
		private Uncertain<LivestockCounts>? _Goats;
		private Uncertain<LivestockCounts>? _Pigs;
		private Uncertain<LivestockCounts>? _OtherLivestocks;
	}
}