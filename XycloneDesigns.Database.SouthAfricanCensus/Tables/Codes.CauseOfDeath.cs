
namespace XycloneDesigns.Database.SouthAfricanCensus.Tables
{
	[SQLite.Table(SQL.Table)]
	public class CodesCauseOfDeath : Codes
	{
		public static class SQL
		{
			public const string Table = "codes_causeofdeath";

			public const string Code = "code";
			public const string CodeStart = "codestart";
			public const string CodeEnd = "codeend";
			public const string Name = "name";
		}

		[SQLite.Column(SQL.Code)] public string? Code { get; set; }
		[SQLite.Column(SQL.CodeStart)] public string? CodeStart { get; set; }
		[SQLite.Column(SQL.CodeEnd)] public string? CodeEnd { get; set; }
		[SQLite.Column(SQL.Name)] public string? Name { get; set; }
	}
}