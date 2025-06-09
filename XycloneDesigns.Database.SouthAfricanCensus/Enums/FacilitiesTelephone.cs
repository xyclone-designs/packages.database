using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum FacilitiesTelephone
	{
		HouseholdInThisDwellingCellularPhone,
		HouseholdAtANeighbourNearby,
		HouseholdAtAPublicTelephoneNearby,
		HouseholdAtAnotherLocationNearby,
		HouseholdAtAnotherLocationNotNearby,
		HouseholdNoAccessToATelephone,
		HostelInstitution_TelephoneOnPremises,
		HostelInstitution_NoTelephoneOnPremises,
	}

	public static class FacilitiesTelephonesExtensions
	{
		public static FacilitiesTelephone? FromInt(this FacilitiesTelephone _, int value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.DummyHouseholds,

				_ => new NotAvailables?(),
			};

			return (value, year) switch
			{
				(1, Years._1996) => FacilitiesTelephone.HouseholdInThisDwellingCellularPhone,
				(2, Years._1996) => FacilitiesTelephone.HouseholdAtANeighbourNearby,
				(3, Years._1996) => FacilitiesTelephone.HouseholdAtAPublicTelephoneNearby,
				(4, Years._1996) => FacilitiesTelephone.HouseholdAtAnotherLocationNearby,
				(5, Years._1996) => FacilitiesTelephone.HouseholdAtAnotherLocationNotNearby,
				(6, Years._1996) => FacilitiesTelephone.HouseholdNoAccessToATelephone,
				(7, Years._1996) => FacilitiesTelephone.HostelInstitution_TelephoneOnPremises,
				(8, Years._1996) => FacilitiesTelephone.HostelInstitution_NoTelephoneOnPremises,

				(1, _) => FacilitiesTelephone.HouseholdInThisDwellingCellularPhone,
				(2, _) => FacilitiesTelephone.HouseholdAtANeighbourNearby,
				(3, _) => FacilitiesTelephone.HouseholdAtAPublicTelephoneNearby,
				(4, _) => FacilitiesTelephone.HouseholdAtAnotherLocationNearby,
				(5, _) => FacilitiesTelephone.HouseholdAtAnotherLocationNotNearby,
				(6, _) => FacilitiesTelephone.HouseholdNoAccessToATelephone,
				(7, _) => FacilitiesTelephone.HostelInstitution_TelephoneOnPremises,
				(8, _) => FacilitiesTelephone.HostelInstitution_NoTelephoneOnPremises,

				_ => notavailable is null
					? new FacilitiesTelephone?()
					: throw new ArgumentException(string.Format("Province for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}