using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum TypeQuestionnaireHouseholds
	{
		Household,
		Hostel,
		Institution, 
		DummyRecords
	}

	public static class TypeQuestionnaireHouseholdssExtensions
	{
		public static TypeQuestionnaireHouseholds FromString(this TypeQuestionnaireHouseholds _, string value, Years? year, out NotAvailables? notavailable)
		{
			notavailable = null;

			return (value, year) switch
			{
				("H", Years._1996) => TypeQuestionnaireHouseholds.Household,
				("I", Years._1996) => TypeQuestionnaireHouseholds.Hostel,
				("S", Years._1996) => TypeQuestionnaireHouseholds.Institution,
				("D", Years._1996) => TypeQuestionnaireHouseholds.DummyRecords,

				("H", _) => TypeQuestionnaireHouseholds.Household,
				("I", _) => TypeQuestionnaireHouseholds.Hostel,
				("S", _) => TypeQuestionnaireHouseholds.Institution,
				("D", _) => TypeQuestionnaireHouseholds.DummyRecords,

				_ => throw new ArgumentException(string.Format("Province for value '{0}' & year '{1}' not found", value, year))
			};
		}
	}
}