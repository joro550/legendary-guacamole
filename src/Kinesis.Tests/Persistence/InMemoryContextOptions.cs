using Kinesis.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Kinesis.Tests.Persistence
{
    public class InMemoryContextOptions : IContextOptions
    {
        public string DatabaseName { get; set; }

        public DbContextOptions<KinesisContext> CreateContextOptions()
        {
            return new DbContextOptionsBuilder<KinesisContext>()
                .UseInMemoryDatabase(DatabaseName)
                .Options;
        }
    }
}