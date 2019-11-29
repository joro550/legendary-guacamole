using Microsoft.EntityFrameworkCore;

namespace Kinesis.Persistence
{
    public class SqliteContextOptions : IContextOptions
    {
        public string ConnectionString { get; set; }

        public DbContextOptions<KinesisContext> CreateContextOptions() =>
            new DbContextOptionsBuilder<KinesisContext>()
                .UseSqlite(ConnectionString)
                .Options;
    }
}