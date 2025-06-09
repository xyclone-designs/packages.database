
namespace XycloneDesigns.Database.SouthAfricanCensus.Tables
{
	[SQLite.Table(SQL.Table)]
	public class CodesReligion : Codes
	{
		public static class SQL
		{
			public const string Table = "codes_religion";

			public const string Code = "code";
			public const string Value = "value";
		}

		[SQLite.Column(SQL.Code)] public string? Code { get; set; }
		[SQLite.Column(SQL.Value)] public string? Value { get; set; }
	}
}