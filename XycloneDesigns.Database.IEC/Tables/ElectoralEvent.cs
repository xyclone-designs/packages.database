﻿using System;

namespace XycloneDesigns.Database.IEC.Tables
{
	[SQLite.Table(SQL.Table)]
	public class ElectoralEvent : ElectionsItem
    {
		public new class SQL
		{
			public const string Table = "electoralevents";

			public const string Column_Abbr = "abbr";
			public const string Column_Date = "date";
			public const string Column_List_PkBallot = "list_pkBallot";
			public const string Column_List_PkMunicipality_PkParty = "list_pkMunicipality_pkParty";
			public const string Column_List_PkParty_Designation_NationalAllocation = "list_pkParty_designation_nationalAllocation";
			public const string Column_List_PkParty_IdProvince_ProvincialAllocation = "list_pkParty_idProvince_provincialAllocation";
			public const string Column_List_PkParty_IdProvince_RegionalAllocation = "list_pkParty_idProvince_regionalAllocation";
			public const string Column_Name = "name";
			public const string Column_Type = "type";
		}

		public class Types
        {
            public const string Municipal = "municipal";
            public const string National = "national";
            public const string Provincial = "provincial";
            public const string Regional = "regional";
        }

        [SQLite.Column(SQL.Column_Abbr)] public string? Abbr { get; set; }
		[SQLite.Column(SQL.Column_Date)] public string? Date { get; set; }
		[SQLite.Column(SQL.Column_List_PkBallot)] public string? List_PkBallot { get; set; }
        [SQLite.Column(SQL.Column_List_PkMunicipality_PkParty)] public string? List_PkMunicipality_PkParty { get; set; }
        [SQLite.Column(SQL.Column_List_PkParty_Designation_NationalAllocation)] public string? List_PkParty_Designation_NationalAllocation { get; set; }
        [SQLite.Column(SQL.Column_List_PkParty_IdProvince_ProvincialAllocation)] public string? List_PkParty_IdProvince_ProvincialAllocation { get; set; }
        [SQLite.Column(SQL.Column_List_PkParty_IdProvince_RegionalAllocation)] public string? List_PkParty_IdProvince_RegionalAllocation { get; set; }
        [SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }
        [SQLite.Column(SQL.Column_Type)] public string? Type { get; set; }

        public static string? ToType(string? row)
        {
            return true switch
            {
                true when row is null => null,
                true when row.Contains(Types.Municipal, StringComparison.OrdinalIgnoreCase) => Types.Municipal,
                true when row.Contains(Types.National, StringComparison.OrdinalIgnoreCase) => Types.National,
                true when row.Contains(Types.Provincial, StringComparison.OrdinalIgnoreCase) => Types.Provincial,
                true when row.Contains(Types.Regional, StringComparison.OrdinalIgnoreCase) => Types.Regional,

                _ => null
            };
        }
        public static bool IsYear(int date, string? row)
        {
            return row?.Contains(date.ToString()) ?? false;
        }
        public static bool IsNational(string? row)
        {
            return row?.Contains(Types.National, StringComparison.OrdinalIgnoreCase) ?? false;
        }
        public static bool IsProvincial(string? row)
        {
            return row?.Contains(Types.Provincial, StringComparison.OrdinalIgnoreCase) ?? false;
        }
        public static bool IsMunicipal(string? row)
        {
            return row?.Contains(Types.Municipal, StringComparison.OrdinalIgnoreCase) ?? false;
        }
        public static bool IsRegional(string? row)
        {
            return row?.Contains(Types.Regional, StringComparison.OrdinalIgnoreCase) ?? false;
        }
    }
}