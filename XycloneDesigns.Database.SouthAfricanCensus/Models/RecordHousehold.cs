using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Models
{
	public class RecordHousehold : Record
	{
		public Household? Household { get; set; }
		public Land? Land { get; set; }
		public Location? Location { get; set; }
		public Metadata? Metadata { get; set; }
		
		public Uncertain<bool>? DwellingsOwned { get; set; }
		public Uncertain<TypeDwelling>? Dwelling { get; set; }
		public Uncertain<IncomeLevelsMonthly>? HighestIncomeIn { get; set; }
		public Uncertain<Sexes>? HighestIncomeIn_Gender { get; set; }
		public Uncertain<PopulationGroups>? HighestIncomeIn_Race { get; set; }
		public Uncertain<IncomeLevelsMonthlyHousehold>? Income { get; set; }
		public Uncertain<IncomeLevelsMonthlyHousehold>? IncomeAdditional { get; set; }
		public Uncertain<IncomeLevelsMonthlyHousehold>? IncomeReceivedRemittances { get; set; }
		public Uncertain<bool>? Migrant { get; set; }
		public Uncertain<int>? NumberOf_MigrantWorkers { get; set; }
		public Uncertain<int>? NumberOf_HouseholdsSharingOneRoom { get; set; }
	}
}