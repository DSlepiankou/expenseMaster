namespace ExpenseMaster.Constants
{
    public static class Constants
    {
        public const string DbFaileName = "ExpenseDb";

        public const SQLite.SQLiteOpenFlags Flags = 
            SQLite.SQLiteOpenFlags.ReadWrite|
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DBPath =>
            Path.Combine(FileSystem.AppDataDirectory, DbFaileName);
    }
}
