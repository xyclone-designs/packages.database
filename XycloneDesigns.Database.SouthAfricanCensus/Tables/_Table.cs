using static SQLite.SQLiteConnectionExtensions;

namespace XycloneDesigns.Database.SouthAfricanCensus.Tables
{
	public abstract class _Table
    {
		[SQLite.AutoIncrement]
		[SQLite.NotNull]
		[SQLite.PrimaryKey]
        [SQLite.Unique]
        public int Pk { get; set; }
	}
}