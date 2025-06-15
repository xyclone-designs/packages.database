﻿
namespace XycloneDesigns.Database.IEC.Tables
{
	[SQLite.Table(SQL.Table)]
	public class Municipality : ElectionsItem
	{
		public new class SQL
		{
			public const string Table = "municipalities";

			public const string Column_AddressEmail = "addressEmail";
			public const string Column_AddressPostal = "addressPostal";
			public const string Column_AddressStreet = "addressStreet";
			public const string Column_Category = "category";
			public const string Column_GeoCode = "geoCode";
			public const string Column_GeoLevel = "geoLevel";
			public const string Column_IsDisestablished = "isDisestablished";
			public const string Column_List_PkWard = "list_pkWard";
			public const string Column_MiifCategory = "miifCategory";
			public const string Column_Name = "name";
			public const string Column_NameLong = "nameLong";
			public const string Column_NumberFax = "numberFax";
			public const string Column_NumberPhone = "numberPhone";
			public const string Column_PkProvince = "pkProvince";
			public const string Column_Population = "population";
			public const string Column_SquareKms = "squareKms";
			public const string Column_UrlLogo = "urlLogo";
			public const string Column_UrlWebsite = "urlWebsite";
		}
		
        [SQLite.Column(SQL.Column_AddressEmail)] public string? AddressEmail { get; set; }
        [SQLite.Column(SQL.Column_AddressPostal)] public string? AddressPostal { get; set; }
        [SQLite.Column(SQL.Column_AddressStreet)] public string? AddressStreet { get; set; }
		[SQLite.Column(SQL.Column_Category)] public string? Category { get; set; }
		[SQLite.Column(SQL.Column_GeoCode)] public string? GeoCode { get; set; }
		[SQLite.Column(SQL.Column_GeoLevel)] public string? GeoLevel { get; set; }
		[SQLite.Column(SQL.Column_IsDisestablished)] public bool? IsDisestablished { get; set; }
		[SQLite.Column(SQL.Column_List_PkWard)] public string? List_PkWard { get; set; }
		[SQLite.Column(SQL.Column_MiifCategory)] public string? MiifCategory { get; set; }
		[SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }
		[SQLite.Column(SQL.Column_NameLong)] public string? NameLong { get; set; }
		[SQLite.Column(SQL.Column_NumberFax)] public string? NumberFax { get; set; }
		[SQLite.Column(SQL.Column_NumberPhone)] public string? NumberPhone { get; set; }
		[SQLite.Column(SQL.Column_PkProvince)] public int? PkProvince { get; set; }
		[SQLite.Column(SQL.Column_Population)] public int? Population { get; set; }
		[SQLite.Column(SQL.Column_SquareKms)] public decimal? SquareKms { get; set; }
		[SQLite.Column(SQL.Column_UrlLogo)] public string? UrlLogo { get; set; }
		[SQLite.Column(SQL.Column_UrlWebsite)] public string? UrlWebsite { get; set; }
    }
}