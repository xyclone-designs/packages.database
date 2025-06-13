using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Models
{
    public class Personhood : _Model
	{
		public Uncertain<int>? Age { get; set; }
		public Uncertain<CitizenshipStatus>? Citizenship { get; set; }
		public Uncertain<Countries>? CountryBirth { get; set; }
		public Uncertain<Countries>? CountryCitizenOther { get; set; }
		public Uncertain<Countries>? CountryCitizenSouthAfrica { get; set; }
		public Uncertain<EducationLevels>? HighestSchoolClass1 { get; set; }
		public Uncertain<EducationLevels>? HighestSchoolClass2 { get; set; }
		public Uncertain<EducationFields>? HighestQualification1 { get; set; }
		public Uncertain<EducationFields>? HighestQualification2 { get; set; }
		public Uncertain<bool>? IsAliveMother { get; set; }
		public Uncertain<bool>? IsAliveFather { get; set; }
		public Uncertain<Languages>? Language1 { get; set; }
		public Uncertain<Languages>? Language2 { get; set; }
		public Uncertain<MaritalStatuses>? MaritalStatus { get; set; }
		public Uncertain<bool>? Migrant { get; set; }
		public Uncertain<PopulationGroups>? Race { get; set; }
		public Uncertain<Religions>? Religion { get; set; }
		public Uncertain<Sexes>? Sex { get; set; }
		public Uncertain<EmploymentStatuses>? StatusEmployment { get; set; }
		public Uncertain<StatusStudying>? StatusStudying { get; set; }
		public Uncertain<StatusWork>? StatusWork { get; set; }
	}
}