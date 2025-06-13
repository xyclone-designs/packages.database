
namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public enum ImputationFlags 
	{
		NoImputation = 1,
		LogicalImputationFromBlank = 2,
		LogicalImputationNonBlank = 3,
		HotDeckImputationFromBlank = 4,
		HotDeckImputationNonBlank = 5,
	}
}