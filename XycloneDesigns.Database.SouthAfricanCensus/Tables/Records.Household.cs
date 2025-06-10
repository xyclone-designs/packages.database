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

		public string? NumberOf_MigrantWorkers
		{ 
			get => _NumberOf_MigrantWorkers?.ToString(); 
			set => _NumberOf_MigrantWorkers = Uncertain.FromString<int>(value); 
		}
		public string? NumberOf_HouseholdsSharingOneRoom
		{ 
			get => _NumberOf_HouseholdsSharingOneRoom?.ToString(); 
			set => _NumberOf_HouseholdsSharingOneRoom = Uncertain.FromString<int>(value); 
		}

		public Sexes? HighestIncomeIn_Gender { get; set; }
		public PopulationGroups? HighestIncomeIn_Race { get; set; }

		public IncomeLevelsMonthlyHousehold? Income { get; set; }
		public IncomeLevelsMonthlyHousehold? IncomeAdditional { get; set; }
		public IncomeLevelsMonthlyHousehold? IncomeReceivedRemittances { get; set; } 

		public Sexes? HeadOf_Sex { get; set; }
		public string? HeadOf_Age
		{ 
			get => _HeadOf_Age?.ToString(); 
			set => _HeadOf_Age = Uncertain.FromString<int>(value); 
		}
		public PopulationGroups? HeadOf_Race { get; set; }
		public EducationLevels? HeadOf_Education { get; set; }
		public EmploymentStatuses? HeadOf_EmploymentStatus { get; set; }
		public string? HeadOf_Occupation { get; set; }
		public IncomeLevelsMonthly? HeadOf_IncomeLevel { get; set; }

		public string? HouseholdSize
		{ 
			get => _HouseholdSize?.ToString(); 
			set => _HouseholdSize = Uncertain.FromString<int>(value); 
		}
		public TypeQuestionnaireHouseholds? QuestionType { get; set; }
		public string? Urban
		{ 
			get => _Urban?.ToString(); 
			set => _Urban = Uncertain.FromString<bool>(value); 
		}
		public string? Migrant
		{ 
			get => _Migrant?.ToString(); 
			set => _Migrant = Uncertain.FromString<bool>(value); 
		}
		public string? Rooms
		{ 
			get => _Rooms?.ToString(); 
			set => _Rooms = Uncertain.FromString<int>(value); 
		}
		public TypeDwelling? Dwelling { get; set; } 
		public string? DwellingsOwned
		{ 
			get => _DwellingsOwned?.ToString(); 
			set => _DwellingsOwned = Uncertain.FromString<bool> (value); 
		}

		public FacilitiesToilet? FacilitiesToilet { get; set; }
		public FacilitiesTelephone? FacilitiesTelephone { get; set; }
		public FacilitiesRefuseDisposal? FacilitiesRefuseDisposal { get; set; }

		public SourceOfWater? SourceOfWater { get; set; }
		public SourceOfFuel? SourceOfFuelCooking { get; set; }
		public SourceOfFuel? SourceOfFuelHeating { get; set; }
		public SourceOfFuel? SourceOfFuelLighting { get; set; }


		private Uncertain<int>? _NumberOf_MigrantWorkers;
		private Uncertain<int>? _NumberOf_HouseholdsSharingOneRoom;
		private Uncertain<int>? _HeadOf_Age;
		private Uncertain<int>? _HouseholdSize;
		private Uncertain<bool>? _Urban;
		private Uncertain<bool>? _Migrant;
		private Uncertain<int>? _Rooms;
		private Uncertain<bool>? _DwellingsOwned;
	}
}