using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum ImputationFlags 
	{
		NoImputation,
		LogicalImputationFromBlank,
		LogicalImputationNonBlank,
		HotDeckImputationFromBlank,
		HotDeckImputationNonBlank,
	}

	public static class ImputationFlagsExtensions
	{
		public static ImputationFlags? FromInt(this ImputationFlags _, int? value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				_ => new NotAvailables?(),
			};

			if (value is null) return null;

			return (value.Value, year) switch
			{
				(0, Years._2001) => ImputationFlags.NoImputation,
				(1, Years._2001) => ImputationFlags.LogicalImputationFromBlank,
				(2, Years._2001) => ImputationFlags.LogicalImputationNonBlank,
				(3, Years._2001) => ImputationFlags.HotDeckImputationFromBlank,
				(4, Years._2001) => ImputationFlags.HotDeckImputationNonBlank,

				(0, _) => ImputationFlags.NoImputation,
				(1, _) => ImputationFlags.LogicalImputationFromBlank,
				(2, _) => ImputationFlags.LogicalImputationNonBlank,
				(3, _) => ImputationFlags.HotDeckImputationFromBlank,
				(4, _) => ImputationFlags.HotDeckImputationNonBlank,

				_ => notavailable is null
					? new ImputationFlags?()
					: throw new ArgumentException(string.Format("ImputationFlags for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}