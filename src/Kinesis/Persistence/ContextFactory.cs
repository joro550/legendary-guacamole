using System;
using Microsoft.EntityFrameworkCore;

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

    public class ContextOptionsBuilder
    {

    }

    public interface IContextOptions
    {
        DbContextOptions<KinesisContext> CreateContextOptions();
    }
}
