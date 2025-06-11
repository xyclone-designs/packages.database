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

			public const string Column_AgeOfDeceased = "ageofdeceased";
			public const string Column_AnybodyDied = "anybodydied";
			public const string Column_DateOfDeath = "dateofdeath";
			public const string Column_Gender = "gender";
			public const string Column_HowManyDied = "howmanydied";
			public const string Column_ImputationFlags = "imputationflags";
			public const string Column_WasDeathFromViolence = "wasdeathfromviolence";
			public const string Column_WasPregnantWhenDeceased = "waspregnantwhendeceased";
		}

		[SQLite.Column(SQL.Column_AgeOfDeceased)] public int? AgeOfDeceased { get; set; }
		[SQLite.Column(SQL.Column_AnybodyDied)] public string? AnybodyDied
		{	
			get => _AnybodyDied?.ToString(); 
			set => _AnybodyDied = Uncertain.From<bool>(value);
		}
		[SQLite.Column(SQL.Column_DateOfDeath)] public DateTime? DateOfDeath { get; set; }
		[SQLite.Column(SQL.Column_Gender)] public string? Gender
		{
			get => _Gender?.ToString();
			set => _Gender = Uncertain.From<Sexes>(value);
		}
		[SQLite.Column(SQL.Column_HowManyDied)] public string? HowManyDied
		{
			get => _HowManyDied?.ToString();
			set => _HowManyDied = Uncertain.From<int>(value);
		}
		[SQLite.Column(SQL.Column_ImputationFlags)] public string? ImputationFlags
		{
			get => _ImputationFlags?.ToString();
			set => _ImputationFlags = Uncertain.From<ImputationFlags>(value);
		}
		[SQLite.Column(SQL.Column_WasDeathFromViolence)] public bool? WasDeathFromViolence { get; set; }
		[SQLite.Column(SQL.Column_WasPregnantWhenDeceased)] public string? WasPregnantWhenDeceased
		{	
			get => _WasPregnantWhenDeceased?.ToString(); 
			set => _WasPregnantWhenDeceased = Uncertain.From<bool>(value);
		}

		
		public Uncertain<bool>? _AnybodyDied;
		public Uncertain<Sexes>? _Gender;
		public Uncertain<int>? _HowManyDied;
		public Uncertain<ImputationFlags>? _ImputationFlags;
		public Uncertain<bool>? _WasPregnantWhenDeceased;
	}
}