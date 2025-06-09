
namespace XycloneDesigns.Database.SouthAfricanCensus.Structs
{
	public struct Uncertain<TValue> 
	{
		public TValue? Value { get; set; }
		public bool Unspecified { get; set; }
		public NotAvailables? NotAvailable { get; set; }
	}
}