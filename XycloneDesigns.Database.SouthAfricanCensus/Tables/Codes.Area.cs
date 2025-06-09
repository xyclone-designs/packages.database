
namespace XycloneDesigns.Database.SouthAfricanCensus.Tables
{
	[SQLite.Table(SQL.Table)]
	public class CodesArea : Codes
	{
		public static class SQL
		{
			public const string Table = "codes_area";

			public const string ProvinceCode = "provincecode";
			public const string ProvinceName = "provincename";
			public const string DistrictCouncilCode = "districtcouncilcode";
			public const string DistrictCouncilName = "districtcouncilname";
			public const string TLCTRCCode = "tlctrccode";
			public const string TLCTRCName = "tlctrcname";
		}

		[SQLite.Column(SQL.ProvinceCode)] public int? ProvinceCode { get; set; }
		[SQLite.Column(SQL.ProvinceName)] public string? ProvinceName { get; set; }
		[SQLite.Column(SQL.DistrictCouncilCode)] public int? DistrictCouncilCode { get; set; }
		[SQLite.Column(SQL.DistrictCouncilName)] public string? DistrictCouncilName { get; set; }
		[SQLite.Column(SQL.TLCTRCCode)] public int? TLCTRCCode { get; set; }
		[SQLite.Column(SQL.TLCTRCName)] public string? TLCTRCName { get; set; }
	}
}