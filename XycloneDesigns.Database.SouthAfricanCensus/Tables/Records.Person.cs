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
		}

		public Provinces? Province { get; set; }
		public int? NumberPerson { get; set; }
		public int? NumberHousehold { get; set; }
		public int? CouncilCodeDistrict { get; set; } 
		public int? CouncilCodeMagisterial { get; set; } 
		public int? CouncilCodeTransitionalLocalRural { get; set; }

		public TypeQuestionnaireHouseholds? TypeQuestionnaire { get; set; }
		public string? Urban 
		{ 
			get => _Urban?.ToString();
			set => _Urban = Uncertain.FromString<bool>(value);
		}
		public TypeInstitution? TypeInstitution { get; set; }
		public Sexes? Sex { get; set; }
		public string? Age 
		{ 
			get => _Age?.ToString();
			set => _Age = Uncertain.FromString<int>(value);
		} 
		public Relations? Relationship { get; set; }
		public MaritalStatuses? MaritalStatus { get; set; }
		public PopulationGroups? Race { get; set; }
		public Languages? Language1 { get; set; }
		public Languages? Language2 { get; set; }
		public Religions? Religion { get; set; }
		public Countries? CountryBirth { get; set; }

		public string? CountryCitizenSouthAfrica 
		{ 
			get => _CountryCitizenSouthAfrica?.ToString();
			set => _CountryCitizenSouthAfrica = Uncertain.FromString<Countries>(value);
		} 
		public string? CountryCitizenOther 
		{ 
			get => _CountryCitizenOther?.ToString();
			set => _CountryCitizenOther = Uncertain.FromString<Countries>(value);
		}
		public CitizenshipStatus? Citizenship { get; set; }
		public string? MigrantWorker 
		{ 
			get => _MigrantWorker?.ToString();
			set => _MigrantWorker = Uncertain.FromString<bool>(value);
		}
		public UsualResidence? UsualResidencePlaceOf { get; set; }
		public int? UsualResidenceMagesterialCode { get; set; }
		public string? UsualResidenceYearMoved 
		{ 
			get => _UsualResidenceYearMoved?.ToString();
			set => _UsualResidenceYearMoved = Uncertain.FromString<int>(value);
		}
		public int? PreviousResidenceMagesterialCode { get; set; }
		public TypeDisability? Disability { get; set; }
		public string? DisabilitySight 
		{ 
			get => _DisabilitySight?.ToString();
			set => _DisabilitySight = Uncertain.FromString<bool>(value);
		}
		public string? DisabilityHearing 
		{ 
			get => _DisabilityHearing?.ToString();
			set => _DisabilityHearing = Uncertain.FromString<bool>(value);
		}
		public string? DisabilityPhysical 
		{ 
			get => _DisabilityPhysical?.ToString();
			set => _DisabilityPhysical = Uncertain.FromString<bool>(value);
		}
		public string? DisabilityMental 
		{ 
			get => _DisabilityMental?.ToString();
			set => _DisabilityMental = Uncertain.FromString<bool>(value);
		}
		public string? IsAliveMother 
		{ 
			get => _IsAliveMother?.ToString();
			set => _IsAliveMother = Uncertain.FromString<bool>(value);
		}
		public string? IsAliveFather 
		{ 
			get => _IsAliveFather?.ToString();
			set => _IsAliveFather = Uncertain.FromString<bool>(value);
		}
		public string? ChildrenBorn 
		{ 
			get => _ChildrenBorn?.ToString();
			set => _ChildrenBorn = Uncertain.FromString<int>(value);
		}
		public string? ChildrenAlive 
		{ 
			get => _ChildrenAlive?.ToString();
			set => _ChildrenAlive = Uncertain.FromString<int>(value);
		}
		public string? AgeOfMotherAtFirstBorn 
		{ 
			get => _AgeOfMotherAtFirstBorn?.ToString();
			set => _AgeOfMotherAtFirstBorn = Uncertain.FromString<int>(value);
		}
		public string? NumberBirthsLast12Months 
		{ 
			get => _NumberBirthsLast12Months?.ToString();
			set => _NumberBirthsLast12Months = Uncertain.FromString<int>(value);
		}
		public EducationLevels? HighestSchoolClass1 { get; set; }
		public EducationFields? HighestQualification1 { get; set; }
		public StatusStudying? StatusStudying { get; set; }
		public EducationLevels? HighestSchoolClass2 { get; set; }
		public EducationFields? HighestQualification2 { get; set; }
		public EmploymentStatuses? EmploymentStatus { get; set; }
		public string? FullOrPartTime 
		{
			get => _FullOrPartTime?.ToString();
			set => _FullOrPartTime = Uncertain.FromString<bool>(value);
		}
		public StatusWork? WorkStatus { get; set; }
		public int? OccupationCode { get; set; }
		public int? OccupationCodePrevious { get; set; }
		public int? IndustryCode { get; set; }
		public int? EmploymentMagisterialCode { get; set; }
		public IncomeLevelsMonthly? Income { get; set; }

		private Uncertain<bool>? _Urban;
		private Uncertain<int>? _Age;
		private Uncertain<Countries>? _CountryCitizenSouthAfrica;
		private Uncertain<Countries>? _CountryCitizenOther;
		private Uncertain<bool>? _MigrantWorker;
		private Uncertain<int>? _UsualResidenceYearMoved;
		private Uncertain<bool>? _DisabilitySight;
		private Uncertain<bool>? _DisabilityHearing;
		private Uncertain<bool>? _DisabilityPhysical;
		private Uncertain<bool>? _DisabilityMental;
		private Uncertain<bool>? _IsAliveMother;
		private Uncertain<bool>? _IsAliveFather;
		private Uncertain<int>? _ChildrenBorn;
		private Uncertain<int>? _ChildrenAlive;
		private Uncertain<int>? _AgeOfMotherAtFirstBorn;
		private Uncertain<int>? _NumberBirthsLast12Months;
		private Uncertain<bool>? _FullOrPartTime;
	}
}