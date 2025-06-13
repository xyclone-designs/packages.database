using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Models;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Tables
{
	[SQLite.Table(SQL.Table)]
    public class RecordsHouseholdAgricultural : RecordsHousehold
	{
		public new static class SQL 
		{
			public const string Table = "records_householdagricultural";

			public const string Column_LivestockProduction = "livestockproduction";
			public const string Column_Poultry = "poultry";
			public const string Column_VegetableProduction = "vegetableproduction";
			public const string Column_OtherCrops = "othercrops";
			public const string Column_FodderGrazingPastureGrassForAnimals = "foddergrazingpasturegrassforanimals";
			public const string Column_OtherAgriculturalActivies = "otheragriculturalactivies";
			public const string Column_NoAgriculturalActivies = "noagriculturalactivies";
			public const string Column_Cattle = "cattle";
			public const string Column_Sheep = "sheep";
			public const string Column_Goats = "goats";
			public const string Column_Pigs = "pigs";
			public const string Column_OtherLivestocks = "otherlivestocks";
			public const string Column_Farmland = "farmland";
			public const string Column_BackyardOrSchool = "backyardorschool";
			public const string Column_CommunalOrTribalLand = "communalortriballand";
			public const string Column_OtherPlaceOfAgriculturalActivies = "otherplaceofagriculturalactivies";
		}

		[SQLite.Column(SQL.Column_LivestockProduction)] public int? LivestockProduction { get; set; }
		[SQLite.Column(SQL.Column_Poultry)] public int? Poultry { get; set; }
		[SQLite.Column(SQL.Column_VegetableProduction)] public int? VegetableProduction { get; set; }
		[SQLite.Column(SQL.Column_OtherCrops)] public int? OtherCrops { get; set; }
		[SQLite.Column(SQL.Column_FodderGrazingPastureGrassForAnimals)] public int? FodderGrazingPastureGrassForAnimals { get; set; }
		[SQLite.Column(SQL.Column_OtherAgriculturalActivies)] public int? OtherAgriculturalActivies { get; set; }
		[SQLite.Column(SQL.Column_NoAgriculturalActivies)] public int? NoAgriculturalActivies { get; set; }
		[SQLite.Column(SQL.Column_Cattle)] public int? Cattle { get; set; }
		[SQLite.Column(SQL.Column_Sheep)] public int? Sheep { get; set; }
		[SQLite.Column(SQL.Column_Goats)] public int? Goats { get; set; }
		[SQLite.Column(SQL.Column_Pigs)] public int? Pigs { get; set; }
		[SQLite.Column(SQL.Column_OtherLivestocks)] public int? OtherLivestocks { get; set; }
		[SQLite.Column(SQL.Column_Farmland)] public int? Farmland { get; set; }
		[SQLite.Column(SQL.Column_BackyardOrSchool)] public int? BackyardOrSchool { get; set; }
		[SQLite.Column(SQL.Column_CommunalOrTribalLand)] public int? CommunalOrTribalLand { get; set; }
		[SQLite.Column(SQL.Column_OtherPlaceOfAgriculturalActivies)] public int? OtherPlaceOfAgriculturalActivies { get; set; }

		public Uncertain<LivestockCounts>? _Cattle;
		public Uncertain<LivestockCounts>? _Sheep;
		public Uncertain<LivestockCounts>? _Goats;
		public Uncertain<LivestockCounts>? _Pigs;
		public Uncertain<LivestockCounts>? _OtherLivestocks;

		public void FromModel(RecordHousehold record)
		{
			base.FromModel(record);

			LivestockProduction = record.AgriculturalLand?.LivestockProduction;
			Poultry = record.AgriculturalLand?.Poultry;
			VegetableProduction = record.AgriculturalLand?.VegetableProduction;
			OtherCrops = record.AgriculturalLand?.OtherCrops;
			FodderGrazingPastureGrassForAnimals = record.AgriculturalLand?.FodderGrazingPastureGrassForAnimals;
			OtherAgriculturalActivies = record.AgriculturalLand?.OtherAgriculturalActivies;
			NoAgriculturalActivies = record.AgriculturalLand?.NoAgriculturalActivies;
			Cattle = record.AgriculturalLand?.Cattle?.ToInt(_ => (int?)_);
			Sheep = record.AgriculturalLand?.Sheep?.ToInt(_ => (int?)_);
			Goats = record.AgriculturalLand?.Goats?.ToInt(_ => (int?)_);
			Pigs = record.AgriculturalLand?.Pigs?.ToInt(_ => (int?)_);
			OtherLivestocks = record.AgriculturalLand?.OtherLivestocks?.ToInt(_ => (int?)_);
			Farmland = record.AgriculturalLand?.Farmland;
			BackyardOrSchool = record.AgriculturalLand?.BackyardOrSchool;
			CommunalOrTribalLand = record.AgriculturalLand?.CommunalOrTribalLand;
			OtherPlaceOfAgriculturalActivies = record.AgriculturalLand?.OtherPlaceOfAgriculturalActivies;
		}
	}
}