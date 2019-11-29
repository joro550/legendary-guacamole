using Xunit;
using Kinesis.Persistence;
using Kinesis.Persistence.Adapters;
using Kinesis.Streams.Handlers;
using Kinesis.Streams.Models;
using Kinesis.Tests.Persistence;
using static Kinesis.Persistence.ContextFactory;

namespace Kinesis.Tests.Streams
{
    public class ListStreamTests
    {
        [Fact]
        public void Test1()
        {
            KinesisStore.Instance = new EfStoreAdapter(CreateContext(builder =>
                builder.UseInMemoryDatabase("KinesisDatabase")));

            var listStreamRequest = new ListStreamRequest();
            var listStreamCommand = new ListStreamHandler(listStreamRequest);
        }
    }
}
