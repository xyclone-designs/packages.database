using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Tables
{
    public class RecordsPerson : Records
	{
		public static class SQL
		{
			public const string Table = "records_person";
		}

		public Provinces? Province { get; set; }
		public int? NumberPerson { get; set; }
		public int? NumberHousehold { get; set; }
		public int? CouncilCodeDistrict { get; set; } 
		public int? CouncilCodeMagisterial { get; set; } 
		public int? CouncilCodeTransitionalLocalRural { get; set; }

		public TypeQuestionnaireHouseholds? TypeQuestionnaire { get; set; }
		public Uncertain<bool>? Urban { get; set; }
		public TypeInstitution? TypeInstitution { get; set; }
		public Sexes? Sex { get; set; }
		public Uncertain<int>? Age { get; set; } 
		public Relations? Relationship { get; set; }
		public MaritalStatuses? MaritalStatus { get; set; }
		public PopulationGroups? Race { get; set; }
		public Languages? Language1 { get; set; }
		public Languages? Language2 { get; set; }
		public Religions? Religion { get; set; }
		public Countries? CountryBirth { get; set; }

		public Uncertain<Countries>? CountryCitizenSouthAfrica { get; set; } 
		public Uncertain<Countries>? CountryCitizenOther { get; set; }
		public CitizenshipStatus? Citizenship { get; set; }
		public Uncertain<bool>? MigrantWorker { get; set; }
		public UsualResidence? UsualResidencePlaceOf { get; set; }
		public int? UsualResidenceMagesterialCode { get; set; }
		public Uncertain<int>? UsualResidenceYearMoved { get; set; }
		public int? PreviousResidenceMagesterialCode { get; set; }
		public TypeDisability? Disability { get; set; }
		public Uncertain<bool>? DisabilitySight { get; set; }
		public Uncertain<bool>? DisabilityHearing { get; set; }
		public Uncertain<bool>? DisabilityPhysical { get; set; }
		public Uncertain<bool>? DisabilityMental { get; set; }
		public Uncertain<bool>? IsAliveMother { get; set; }
		public Uncertain<bool>? IsAliveFather { get; set; }
		public Uncertain<int>? ChildrenBorn { get; set; }
		public Uncertain<int>? ChildrenAlive { get; set; }
		public Uncertain<int>? AgeOfMotherAtFirstBorn { get; set; }
		public Uncertain<int>? NumberBirthsLast12Months { get; set; }
		public EducationLevels? HighestSchoolClass1 { get; set; }
		public EducationFields? HighestQualification1 { get; set; }
		public StatusStudying? StatusStudying { get; set; }
		public EducationLevels? HighestSchoolClass2 { get; set; }
		public EducationFields? HighestQualification2 { get; set; }
		public EmploymentStatuses? EmploymentStatus { get; set; }
		public Uncertain<bool>? FullOrPartTime { get; set; }
		public StatusWork? WorkStatus { get; set; }
		public int? OccupationCode { get; set; }
		public int? OccupationCodePrevious { get; set; }
		public int? IndustryCode { get; set; }
		public int? EmploymentMagisterialCode { get; set; }
		public IncomeLevelsMonthly? Income { get; set; }
	}
}