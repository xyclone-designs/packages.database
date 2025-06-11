﻿
namespace XycloneDesigns.Database.SouthAfricanCensus.Tables
{
	[SQLite.Table(SQL.Table)]
	public class CodesOccupation : Codes
	{
		public static class SQL
		{
			public const string Table = "codes_occupation";

			public const string Column_Code1Digit = "code1digit";
			public const string Column_Code2Digit = "code2digit";
			public const string Column_Code3Digit = "code3digit";
			public const string Column_Value = "value";
		}

		[SQLite.Column(SQL.Column_Code1Digit)] public string? Code1Digit { get; set; }
		[SQLite.Column(SQL.Column_Code2Digit)] public string? Code2Digit { get; set; }
		[SQLite.Column(SQL.Column_Code3Digit)] public string? Code3Digit { get; set; }
		[SQLite.Column(SQL.Column_Value)] public string? Value { get; set; }
	}
}