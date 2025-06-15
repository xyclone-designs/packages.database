﻿
namespace XycloneDesigns.Database.IEC.Tables
{
	[SQLite.Table(SQL.Table)]
    public class Ward : ElectionsItem
    {
        public new class SQL
        {
            public const string Table = "wards";

			public const string Column_Id = "id";
			public const string Column_List_PkVotingDistrict = "list_pkVotingDistrict";
			public const string Column_PkMunicipality = "pkMunicipality";
            public const string Column_PkProvince = "pkProvince";
        }

		[SQLite.Unique]
		[SQLite.Column(SQL.Column_Id)] public string? Id { get; set; }
		[SQLite.Column(SQL.Column_List_PkVotingDistrict)] public string? List_PkVotingDistrict { get; set; }
        [SQLite.Column(SQL.Column_PkMunicipality)] public int? PkMunicipality { get; set; }
        [SQLite.Column(SQL.Column_PkProvince)] public int? PkProvince { get; set; }        
    }
}