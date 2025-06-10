using System;

using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Tables
{
	[SQLite.Table(SQL.Table)]
    public class RecordsMortality : Records
	{
		public static class SQL
		{
			public const string Table = "records_mortality";
		}

		public string? AnybodyDied
		{	
			get => _AnybodyDied?.ToString(); 
			set => _AnybodyDied = Uncertain.FromString<bool>(value);
		}
		public string? HowManyDied
		{	
			get => _HowManyDied?.ToString(); 
			set => _HowManyDied = Uncertain.FromString<int>(value);
		}
		public DateTime? DateOfDeath { get; set; }
		public Sexes? Gender { get; set; }
		public int? AgeOfDeceased { get; set; }
		public bool? WasDeathFromViolence { get; set; }
		public string? WasPregnantWhenDeceased
		{	
			get => _WasPregnantWhenDeceased?.ToString(); 
			set => _WasPregnantWhenDeceased = Uncertain.FromString<bool>(value);
		}
		public ImputationFlags? ImputationFlags { get; set; }

		private Uncertain<bool>? _AnybodyDied;
		private Uncertain<int>? _HowManyDied;
		private Uncertain<bool>? _WasPregnantWhenDeceased;

	}
}