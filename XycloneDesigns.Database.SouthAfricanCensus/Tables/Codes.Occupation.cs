
namespace XycloneDesigns.Database.SouthAfricanCensus.Tables
{
	[SQLite.Table(SQL.Table)]
	public class CodesOccupation : Codes
	{
		public static class SQL
		{
			public const string Table = "codes_occupation";

			public const string Code1Digit = "code1digit";
			public const string Code2Digit = "code2digit";
			public const string Code3Digit = "code3digit";
			public const string Value = "value";
		}

		[SQLite.Column(SQL.Code1Digit)] public string? Code1Digit { get; set; }
		[SQLite.Column(SQL.Code2Digit)] public string? Code2Digit { get; set; }
		[SQLite.Column(SQL.Code3Digit)] public string? Code3Digit { get; set; }
		[SQLite.Column(SQL.Value)] public string? Value { get; set; }
	}
}