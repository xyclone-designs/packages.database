using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Models
{
    public class Residence : _Model
	{
		public int? PreviousMagesterialCode { get; set; }
		public int? UsualMagesterialCode { get; set; }
		public Uncertain<UsualResidence>? UsualPlaceOf { get; set; }
		public Uncertain<int>? UsualYearMoved { get; set; }
	}
}