using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Models
{
    public class RecordPerson : Record
	{
		public Disabilities? Disabilities { get; set; }
		public Location? Location { get; set; }
		public Metadata? Metadata { get; set; }
		public Motherhood? Motherhood { get; set; }
		public Occupation? Occupation { get; set; }
		public Personhood? Personhood { get; set; }
		public Residence? Residence { get; set; }
		public int? NumberHousehold { get; set; }
		public int? NumberPerson { get; set; }
		public Uncertain<Relations>? Relationship { get; set; }
		
	}
}