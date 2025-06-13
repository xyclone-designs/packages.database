using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Models
{
    public class Household : _Model
	{
		public Uncertain<FacilitiesToilet>? FacilitiesToilet { get; set; }
		public Uncertain<FacilitiesTelephone>? FacilitiesTelephone { get; set; }
		public Uncertain<FacilitiesRefuseDisposal>? FacilitiesRefuseDisposal { get; set; }
		public Uncertain<int>? Rooms { get; set; }
		public Uncertain<int>? Size { get; set; }
		public Uncertain<SourceOfWater>? SourceOfWater { get; set; }
		public Uncertain<SourceOfFuel>? SourceOfFuelCooking { get; set; }
		public Uncertain<SourceOfFuel>? SourceOfFuelHeating { get; set; }
		public Uncertain<SourceOfFuel>? SourceOfFuelLighting { get; set; }
		public Uncertain<bool>? Urban { get; set; }

		public Personhood? HeadOf { get; set; }
	}
}