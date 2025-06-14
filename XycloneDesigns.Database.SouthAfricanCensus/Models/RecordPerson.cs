using XycloneDesigns.Database.SouthAfricanCensus.Enums;

namespace XycloneDesigns.Database.SouthAfricanCensus.Models
{
    public class RecordPerson : Record
	{
		public Disabilities? Disabilities { get; set; }
		public Household? Household { get; set; }
		public Location? Location { get; set; }
		public Metadata? Metadata { get; set; }
		public Motherhood? Motherhood { get; set; }
		public int? Number { get; set; }
		public Occupation? Occupation { get; set; }
		public Personhood? Personhood { get; set; }
		public Residence? Residence { get; set; }	
	}
}