using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Tables
{
	[SQLite.Table(SQL.Table)]
    public class RecordsPerson : Records
	{
		public static class SQL
		{
			public const string Table = "records_person";

			public const string Column_Age = "age";
			public const string Column_AgeOfMotherAtFirstBorn = "ageofmotheratfirstborn";
			public const string Column_ChildrenBorn = "childrenborn";
			public const string Column_ChildrenAlive = "childrenalive";
			public const string Column_Citizenship = "citizenship";
			public const string Column_CouncilCodeDistrict = "councilcodedistrict";
			public const string Column_CouncilCodeMagisterial = "councilcodemagisterial";
			public const string Column_CouncilCodeTransitionalLocalRural = "councilcodetransitionallocalrural";
			public const string Column_CountryBirth = "countrybirth";
			public const string Column_CountryCitizenOther = "countrycitizenother";
			public const string Column_CountryCitizenSouthAfrica = "countrycitizensouthafrica";
			public const string Column_Disability = "disability";
			public const string Column_DisabilitySight = "disabilitysight";
			public const string Column_DisabilityHearing = "disabilityhearing";
			public const string Column_DisabilityPhysical = "disabilityphysical";
			public const string Column_DisabilityMental = "disabilitymental";
			public const string Column_FullOrPartTime = "fullorparttime";
			public const string Column_EmploymentMagisterialCode = "employmentmagisterialcode";
			public const string Column_HighestSchoolClass1 = "highestschoolclass1";
			public const string Column_HighestSchoolClass2 = "highestschoolclass2";
			public const string Column_HighestQualification1 = "highestqualification1";
			public const string Column_HighestQualification2 = "highestqualification2";
			public const string Column_Income = "income";
			public const string Column_IndustryCode = "industrycode";
			public const string Column_IsAliveMother = "isalivemother";
			public const string Column_IsAliveFather = "isalivefather";
			public const string Column_Language1 = "language1";
			public const string Column_Language2 = "language2";
			public const string Column_MaritalStatus = "maritalstatus";
			public const string Column_MigrantWorker = "migrantworker";
			public const string Column_NumberBirthsLast12Months = "numberbirthslast12months";
			public const string Column_NumberHousehold = "numberhousehold";
			public const string Column_NumberPerson = "numberperson";
			public const string Column_OccupationCode = "occupationcode";
			public const string Column_OccupationCodePrevious = "occupationcodeprevious";
			public const string Column_Province = "province";
			public const string Column_PreviousResidenceMagesterialCode = "previousresidencemagesterialcode";
			public const string Column_Race = "race";
			public const string Column_Relationship = "relationship";
			public const string Column_Religion = "religion";
			public const string Column_TypeInstitution = "typeinstitution";
			public const string Column_TypeQuestionnaire = "typequestionnaire";
			public const string Column_Sex = "sex";
			public const string Column_StatusEmployment = "statusemployment";
			public const string Column_StatusStudying = "statusstudying";
			public const string Column_StatusWork = "statuswork";
			public const string Column_Urban = "urban";
			public const string Column_UsualResidenceMagesterialCode = "usualresidencemagesterialcode";
			public const string Column_UsualResidencePlaceOf = "usualresidenceplaceof";
			public const string Column_UsualResidenceYearMoved = "usualresidenceyearmoved";
		}

		[SQLite.Column(SQL.Column_Age)] public string? Age 
		{ 
			get => _Age?.ToString();
			set => _Age = Uncertain.From<int>(value);
		}
		[SQLite.Column(SQL.Column_AgeOfMotherAtFirstBorn)] public string? AgeOfMotherAtFirstBorn
		{
			get => _AgeOfMotherAtFirstBorn?.ToString();
			set => _AgeOfMotherAtFirstBorn = Uncertain.From<int>(value);
		}
		[SQLite.Column(SQL.Column_ChildrenBorn)] public string? ChildrenBorn
		{
			get => _ChildrenBorn?.ToString();
			set => _ChildrenBorn = Uncertain.From<int>(value);
		}
		[SQLite.Column(SQL.Column_ChildrenAlive)] public string? ChildrenAlive
		{
			get => _ChildrenAlive?.ToString();
			set => _ChildrenAlive = Uncertain.From<int>(value);
		}
		[SQLite.Column(SQL.Column_Citizenship)] public string? Citizenship
		{
			get => _Citizenship?.ToString();
			set => _Citizenship = Uncertain.From<CitizenshipStatus>(value);
		}
		[SQLite.Column(SQL.Column_CouncilCodeDistrict)] public int? CouncilCodeDistrict { get; set; }
		[SQLite.Column(SQL.Column_CouncilCodeMagisterial)] public int? CouncilCodeMagisterial { get; set; }
		[SQLite.Column(SQL.Column_CouncilCodeTransitionalLocalRural)] public int? CouncilCodeTransitionalLocalRural { get; set; }
		[SQLite.Column(SQL.Column_CountryBirth)] public string? CountryBirth
		{
			get => _CountryBirth?.ToString();
			set => _CountryBirth = Uncertain.From<Countries>(value);
		}
		[SQLite.Column(SQL.Column_CountryCitizenOther)] public string? CountryCitizenOther
		{
			get => _CountryCitizenOther?.ToString();
			set => _CountryCitizenOther = Uncertain.From<Countries>(value);
		}
		[SQLite.Column(SQL.Column_CountryCitizenSouthAfrica)] public string? CountryCitizenSouthAfrica
		{
			get => _CountryCitizenSouthAfrica?.ToString();
			set => _CountryCitizenSouthAfrica = Uncertain.From<Countries>(value);
		}
		[SQLite.Column(SQL.Column_Disability)] public string? Disability
		{
			get => _Disability?.ToString();
			set => _Disability = Uncertain.From<TypeDisability>(value);
		}
		[SQLite.Column(SQL.Column_DisabilitySight)] public string? DisabilitySight
		{
			get => _DisabilitySight?.ToString();
			set => _DisabilitySight = Uncertain.From<bool>(value);
		}
		[SQLite.Column(SQL.Column_DisabilityHearing)] public string? DisabilityHearing
		{
			get => _DisabilityHearing?.ToString();
			set => _DisabilityHearing = Uncertain.From<bool>(value);
		}
		[SQLite.Column(SQL.Column_DisabilityPhysical)] public string? DisabilityPhysical
		{
			get => _DisabilityPhysical?.ToString();
			set => _DisabilityPhysical = Uncertain.From<bool>(value);
		}
		[SQLite.Column(SQL.Column_DisabilityMental)] public string? DisabilityMental
		{
			get => _DisabilityMental?.ToString();
			set => _DisabilityMental = Uncertain.From<bool>(value);
		}
		[SQLite.Column(SQL.Column_FullOrPartTime)] public string? FullOrPartTime
		{
			get => _FullOrPartTime?.ToString();
			set => _FullOrPartTime = Uncertain.From<bool>(value);
		}
		[SQLite.Column(SQL.Column_EmploymentMagisterialCode)] public int? EmploymentMagisterialCode { get; set; }
		[SQLite.Column(SQL.Column_HighestSchoolClass1)] public string? HighestSchoolClass1
		{
			get => _HighestSchoolClass1?.ToString();
			set => _HighestSchoolClass1 = Uncertain.From<EducationLevels>(value);
		}
		[SQLite.Column(SQL.Column_HighestSchoolClass2)] public string? HighestSchoolClass2 
		{
			get => _HighestSchoolClass2 ?.ToString();
			set => _HighestSchoolClass2  = Uncertain.From<EducationLevels>(value);
		}
		[SQLite.Column(SQL.Column_HighestQualification1)] public string? HighestQualification1 
		{
			get => _HighestQualification1 ?.ToString();
			set => _HighestQualification1  = Uncertain.From<EducationFields>(value);
		}
		[SQLite.Column(SQL.Column_HighestQualification2)] public string? HighestQualification2 
		{
			get => _HighestQualification2 ?.ToString();
			set => _HighestQualification2  = Uncertain.From<EducationFields>(value);
		}
		[SQLite.Column(SQL.Column_Income)] public string? Income 
		{
			get => _Income ?.ToString();
			set => _Income  = Uncertain.From<IncomeLevelsMonthly>(value);
		}
		[SQLite.Column(SQL.Column_IndustryCode)] public int? IndustryCode { get; set; }
		[SQLite.Column(SQL.Column_IsAliveMother)] public string? IsAliveMother
		{
			get => _IsAliveMother?.ToString();
			set => _IsAliveMother = Uncertain.From<bool>(value);
		}
		[SQLite.Column(SQL.Column_IsAliveFather)] public string? IsAliveFather
		{
			get => _IsAliveFather?.ToString();
			set => _IsAliveFather = Uncertain.From<bool>(value);
		}
		[SQLite.Column(SQL.Column_Language1)] public string? Language1
		{
			get => _Language1?.ToString();
			set => _Language1 = Uncertain.From<Languages>(value);
		}
		[SQLite.Column(SQL.Column_Language2)] public string? Language2 
		{
			get => _Language2 ?.ToString();
			set => _Language2  = Uncertain.From<Languages>(value);
		}
		[SQLite.Column(SQL.Column_MaritalStatus)] public string? MaritalStatus 
		{
			get => _MaritalStatus ?.ToString();
			set => _MaritalStatus  = Uncertain.From<MaritalStatuses>(value);
		}
		[SQLite.Column(SQL.Column_MigrantWorker)] public string? MigrantWorker 
		{ 
			get => _MigrantWorker?.ToString();
			set => _MigrantWorker = Uncertain.From<bool>(value);
		}
		[SQLite.Column(SQL.Column_NumberBirthsLast12Months)] public string? NumberBirthsLast12Months
		{
			get => _NumberBirthsLast12Months?.ToString();
			set => _NumberBirthsLast12Months = Uncertain.From<int>(value);
		}
		[SQLite.Column(SQL.Column_NumberHousehold)] public int? NumberHousehold { get; set; }
		[SQLite.Column(SQL.Column_NumberPerson)] public int? NumberPerson { get; set; }
		[SQLite.Column(SQL.Column_OccupationCode)] public int? OccupationCode { get; set; }
		[SQLite.Column(SQL.Column_OccupationCodePrevious)] public int? OccupationCodePrevious { get; set; }
		[SQLite.Column(SQL.Column_Province)] public string? Province
		{
			get => _Province?.ToString();
			set => _Province = Uncertain.From<Provinces>(value);
		}
		[SQLite.Column(SQL.Column_PreviousResidenceMagesterialCode)] public int? PreviousResidenceMagesterialCode { get; set; }
		[SQLite.Column(SQL.Column_Race)] public string? Race
		{
			get => _Race?.ToString();
			set => _Race = Uncertain.From<PopulationGroups>(value);
		}
		[SQLite.Column(SQL.Column_Relationship)] public string? Relationship 
		{
			get => _Relationship ?.ToString();
			set => _Relationship  = Uncertain.From<Relations>(value);
		}
		[SQLite.Column(SQL.Column_Religion)] public string? Religion 
		{
			get => _Religion ?.ToString();
			set => _Religion  = Uncertain.From<Religions>(value);
		}
		[SQLite.Column(SQL.Column_TypeInstitution)] public string? TypeInstitution 
		{
			get => _TypeInstitution ?.ToString();
			set => _TypeInstitution  = Uncertain.From<TypeInstitution>(value);
		}
		[SQLite.Column(SQL.Column_TypeQuestionnaire)] public string? TypeQuestionnaire 
		{
			get => _TypeQuestionnaire ?.ToString();
			set => _TypeQuestionnaire  = Uncertain.From<TypeQuestionnaireHouseholds>(value);
		}
		[SQLite.Column(SQL.Column_Sex)] public string? Sex 
		{
			get => _Sex ?.ToString();
			set => _Sex  = Uncertain.From<Sexes>(value);
		}
		[SQLite.Column(SQL.Column_StatusEmployment)] public string? StatusEmployment 
		{
			get => _StatusEmployment ?.ToString();
			set => _StatusEmployment  = Uncertain.From<EmploymentStatuses>(value);
		}
		[SQLite.Column(SQL.Column_StatusStudying)] public string? StatusStudying 
		{
			get => _StatusStudying ?.ToString();
			set => _StatusStudying  = Uncertain.From<StatusStudying>(value);
		}
		[SQLite.Column(SQL.Column_StatusWork)] public string? StatusWork 
		{
			get => _StatusWork ?.ToString();
			set => _StatusWork  = Uncertain.From<StatusWork>(value);
		}
		[SQLite.Column(SQL.Column_Urban)] public string? Urban
		{
			get => _Urban?.ToString();
			set => _Urban = Uncertain.From<bool>(value);
		}
		[SQLite.Column(SQL.Column_UsualResidenceMagesterialCode)] public int? UsualResidenceMagesterialCode { get; set; }
		[SQLite.Column(SQL.Column_UsualResidencePlaceOf)] public string? UsualResidencePlaceOf 
		{
			get => _UsualResidencePlaceOf ?.ToString();
			set => _UsualResidencePlaceOf  = Uncertain.From<UsualResidence>(value);
		}
		[SQLite.Column(SQL.Column_UsualResidenceYearMoved)] public string? UsualResidenceYearMoved
		{
			get => _UsualResidenceYearMoved?.ToString();
			set => _UsualResidenceYearMoved = Uncertain.From<int>(value);
		}
		
		public Uncertain<int>? _Age;
		public Uncertain<int>? _AgeOfMotherAtFirstBorn;
		public Uncertain<int>? _ChildrenBorn;
		public Uncertain<int>? _ChildrenAlive;
		public Uncertain<CitizenshipStatus>? _Citizenship;
		public Uncertain<Countries>? _CountryBirth;
		public Uncertain<Countries>? _CountryCitizenOther;
		public Uncertain<Countries>? _CountryCitizenSouthAfrica;
		public Uncertain<TypeDisability>? _Disability;
		public Uncertain<bool>? _DisabilitySight;
		public Uncertain<bool>? _DisabilityHearing;
		public Uncertain<bool>? _DisabilityPhysical;
		public Uncertain<bool>? _DisabilityMental;
		public Uncertain<bool>? _FullOrPartTime;
		public Uncertain<EducationLevels>? _HighestSchoolClass1;
		public Uncertain<EducationLevels>? _HighestSchoolClass2;
		public Uncertain<EducationFields>? _HighestQualification1;
		public Uncertain<EducationFields>? _HighestQualification2;
		public Uncertain<IncomeLevelsMonthly>? _Income;
		public Uncertain<bool>? _IsAliveMother;
		public Uncertain<bool>? _IsAliveFather;
		public Uncertain<Languages>? _Language1;
		public Uncertain<Languages>? _Language2;
		public Uncertain<MaritalStatuses>? _MaritalStatus;
		public Uncertain<bool>? _MigrantWorker;
		public Uncertain<int>? _NumberBirthsLast12Months;
		public Uncertain<Provinces>? _Province;
		public Uncertain<PopulationGroups>? _Race;
		public Uncertain<Relations>? _Relationship;
		public Uncertain<Religions>? _Religion;
		public Uncertain<TypeInstitution>? _TypeInstitution;
		public Uncertain<TypeQuestionnaireHouseholds>? _TypeQuestionnaire;
		public Uncertain<Sexes>? _Sex;
		public Uncertain<EmploymentStatuses>? _StatusEmployment;
		public Uncertain<StatusStudying>? _StatusStudying;
		public Uncertain<StatusWork>? _StatusWork;
		public Uncertain<bool>? _Urban;
		public Uncertain<UsualResidence>? _UsualResidencePlaceOf;
		public Uncertain<int>? _UsualResidenceYearMoved;
	}
}