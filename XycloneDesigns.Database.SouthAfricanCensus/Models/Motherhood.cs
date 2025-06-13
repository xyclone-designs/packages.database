using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Models
{
    public class Motherhood : _Model
	{
		public Uncertain<int>? AgeAtFirstBorn { get; set; }
		public Uncertain<int>? ChildrenBorn { get; set; }
		public Uncertain<int>? ChildrenAlive { get; set; }
		public Uncertain<int>? NumberBirthsLast12Months { get; set; }
	}
}