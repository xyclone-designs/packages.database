using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Models
{
    public class Location : _Model
	{
		public int? CouncilCodeDistrict { get; set; }
		public int? CouncilCodeMagisterial { get; set; }
		public int? CouncilCodeTransitionalLocalRural { get; set; }
		public Uncertain<Provinces>? Province { get; set; }
		public Uncertain<int>? Urban { get; set; }
	}
}