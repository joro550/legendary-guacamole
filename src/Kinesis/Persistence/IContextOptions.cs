using Microsoft.EntityFrameworkCore;

namespace Kinesis.Persistence
{
    public interface IContextOptions
    {
        DbContextOptions<KinesisContext> CreateContextOptions();
    }
}