using System;

using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Models
{
    public class RecordMortality : Record
	{
		public Uncertain<int>? AgeOfDeceased { get; set; }		
		public Uncertain<bool>? AnybodyDied { get; set; }
		public DateTime? DateOfDeath { get; set; }
		public Uncertain<Sexes>? Gender { get; set; }
		public Uncertain<int>? HowManyDied { get; set; }
		public Uncertain<ImputationFlags>? ImputationFlags { get; set; }
		public Uncertain<bool>? WasDeathFromViolence { get; set; }
		public Uncertain<bool>? WasPregnantWhenDeceased { get; set; }
	}
}