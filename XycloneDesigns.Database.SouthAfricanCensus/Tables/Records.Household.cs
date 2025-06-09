using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Tables
{
	[SQLite.Table(SQL.Table)]
    public class RecordsHousehold : Records
	{
		public static class SQL
		{
			public const string Table = "records_household";
		}

		public int? Number { get; set; }

		public Provinces? Province { get; set; }
		public int? CouncilCodeDistrict { get; set; }
		public int? CouncilCodeMagisterial { get; set; }
		public int? CouncilCodeTransitionalLocalRural { get; set; }

		public Uncertain<int>? NumberOf_MigrantWorkers { get; set; }
		public Uncertain<int>? NumberOf_HouseholdsSharingOneRoom { get; set; }

		public Sexes? HighestIncomeIn_Gender { get; set; }
		public PopulationGroups? HighestIncomeIn_Race { get; set; }

		public IncomeLevelsMonthlyHousehold? Income { get; set; }
		public IncomeLevelsMonthlyHousehold? IncomeAdditional { get; set; }
		public IncomeLevelsMonthlyHousehold? IncomeReceivedRemittances { get; set; } 

		public Sexes? HeadOf_Sex { get; set; }
		public Uncertain<int>? HeadOf_Age { get; set; }
		public PopulationGroups? HeadOf_Race { get; set; }
		public EducationLevels? HeadOf_Education { get; set; }
		public EmploymentStatuses? HeadOf_EmploymentStatus { get; set; }
		public string? HeadOf_Occupation { get; set; }
		public IncomeLevelsMonthly? HeadOf_IncomeLevel { get; set; }

		public Uncertain<int>? HouseholdSize { get; set; }
		public TypeQuestionnaireHouseholds? QuestionType { get; set; }
		public Uncertain<bool>? Urban { get; set; }
		public Uncertain<bool>? Migrant { get; set; }
		public Uncertain<int>? Rooms { get; set; }
		public TypeDwelling? Dwelling { get; set; } 
		public Uncertain<bool>? DwellingsOwned { get; set; }

		public FacilitiesToilet? FacilitiesToilet { get; set; }
		public FacilitiesTelephone? FacilitiesTelephone { get; set; }
		public FacilitiesRefuseDisposal? FacilitiesRefuseDisposal { get; set; }

		public SourceOfWater? SourceOfWater { get; set; }
		public SourceOfFuel? SourceOfFuelCooking { get; set; }
		public SourceOfFuel? SourceOfFuelHeating { get; set; }
		public SourceOfFuel? SourceOfFuelLighting { get; set; }
	}
}