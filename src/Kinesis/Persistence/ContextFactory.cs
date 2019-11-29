using System;

namespace Kinesis.Persistence
{
    public static class ContextFactory
    {
        public static KinesisContext CreateContext(Func<ContextOptionsBuilder, IContextOptions> createOptions)
        {
            var options = createOptions(new ContextOptionsBuilder());
            return new KinesisContext(options.CreateContextOptions());
        }
    }
}
