namespace Kinesis.Persistence.Adapters
{
    public static class ContextOptionsBuilderExtensions
    {
        public static SqliteContextOptions UseSqlite(this ContextOptionsBuilder builder, string connectionString)
            => new SqliteContextOptions {ConnectionString = connectionString};
    }
}