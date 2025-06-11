using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum StatusWork
	{
		SelfEmployed,
		Employer,
		Employee,
		WorksInFamilyBusiness,
	}

	public static class StatusWorksExtensions
	{
		public static StatusWork? FromInt(this StatusWork _, int? value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,
				(7, Years._1996) => NotAvailables.AgedLessThan15OrNotEmployed,
				(8, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			if (value is null) return null;

			return (value.Value, year) switch
			{
				(1, Years._1996) => StatusWork.SelfEmployed,
				(2, Years._1996) => StatusWork.Employer,
				(3, Years._1996) => StatusWork.Employee,
				(4, Years._1996) => StatusWork.WorksInFamilyBusiness,
				
				(1, _) => StatusWork.SelfEmployed,
				(2, _) => StatusWork.Employer,
				(3, _) => StatusWork.Employee,
				(4, _) => StatusWork.WorksInFamilyBusiness,

				_ => notavailable is null
					? new StatusWork?()
					: throw new ArgumentException(string.Format("Province for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}