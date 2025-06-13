using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Models
{
	public class RecordHousehold : Record
	{
		public AgriculturalLand? AgriculturalLand { get; set; }
		public Household? Household { get; set; }
		public Location? Location { get; set; }

		public int? Number { get; set; }
		
		public Uncertain<bool>? DwellingsOwned { get; set; }
		public Uncertain<TypeDwelling>? Dwelling { get; set; }
		
		public Uncertain<int>? HeadOf_Age { get; set; }
		public Uncertain<EducationLevels>? HeadOf_Education { get; set; }
		public Uncertain<EmploymentStatuses>? HeadOf_EmploymentStatus { get; set; }
		public Uncertain<IncomeLevelsMonthly>? HeadOf_IncomeLevel { get; set; }
		public int? HeadOf_Occupation { get; set; }
		public Uncertain<PopulationGroups>? HeadOf_Race { get; set; }
		public Uncertain<Sexes>? HeadOf_Sex { get; set; }
		public Uncertain<Sexes>? HighestIncomeIn_Gender { get; set; }
		public Uncertain<PopulationGroups>? HighestIncomeIn_Race { get; set; }
		public Uncertain<IncomeLevelsMonthlyHousehold>? Income { get; set; }
		public Uncertain<IncomeLevelsMonthlyHousehold>? IncomeAdditional { get; set; }
		public Uncertain<IncomeLevelsMonthlyHousehold>? IncomeReceivedRemittances { get; set; }
		public Uncertain<bool>? Migrant { get; set; }
		public Uncertain<int>? NumberOf_MigrantWorkers { get; set; }
		public Uncertain<int>? NumberOf_HouseholdsSharingOneRoom { get; set; }
		public Uncertain<TypeQuestionnaireHouseholds>? QuestionType { get; set; }
	}
}