using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum TypeDisability
	{
		Sight,
		Hearing,
		Physical,
		Mental,
		Multiple,
		TypeOfDisabilityNotSpecified,
		NoDisability,
	}

	public static class TypeDisabilitysExtensions
	{
		public static TypeDisability? FromInt(this TypeDisability _, int value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,
				(8, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			return (value, year) switch
			{
				(1, Years._1996) => TypeDisability.Sight,
				(2, Years._1996) => TypeDisability.Hearing,
				(3, Years._1996) => TypeDisability.Physical,
				(4, Years._1996) => TypeDisability.Mental,
				(5, Years._1996) => TypeDisability.Multiple,
				(6, Years._1996) => TypeDisability.TypeOfDisabilityNotSpecified,
				(7, Years._1996) => TypeDisability.NoDisability,

				(1, _) => TypeDisability.Sight,
				(2, _) => TypeDisability.Hearing,
				(3, _) => TypeDisability.Physical,
				(4, _) => TypeDisability.Mental,
				(5, _) => TypeDisability.Multiple,
				(6, _) => TypeDisability.TypeOfDisabilityNotSpecified,
				(7, _) => TypeDisability.NoDisability,

				_ => notavailable is null
					? new TypeDisability?()
					: throw new ArgumentException(string.Format("TypeDisability for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}