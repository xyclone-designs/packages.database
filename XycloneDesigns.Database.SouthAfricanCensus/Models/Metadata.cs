using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Models
{
    public class Metadata : _Model
	{
		public Uncertain<TypeInstitution>? TypeInstitution { get; set; }
		public Uncertain<TypeQuestionnaireHouseholds>? TypeQuestionnaire { get; set; }
	}
}