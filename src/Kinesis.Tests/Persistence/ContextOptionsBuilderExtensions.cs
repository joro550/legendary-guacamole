using Kinesis.Persistence;

namespace Kinesis.Tests.Persistence
{
    public static class ContextOptionsBuilderExtensions
    {
        public static InMemoryContextOptions UseInMemoryDatabase(this ContextOptionsBuilder builder, string databaseName) 
            => new InMemoryContextOptions {DatabaseName = databaseName};
    }
}