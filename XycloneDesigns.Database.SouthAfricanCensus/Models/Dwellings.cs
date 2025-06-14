using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Models
{
    public class Dwellings : _Model
	{
		public Uncertain<TypeDwelling>? Dwelling { get; set; }
		public Uncertain<bool>? Owned { get; set; }

		public Uncertain<bool>? Migrants { get; set; }
		public Uncertain<int>? NumberOf_MigrantWorkers { get; set; }
		public Uncertain<int>? NumberOf_HouseholdsSharingOneRoom { get; set; }
	}
}