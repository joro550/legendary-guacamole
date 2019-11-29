using Kinesis.Persistence.Tables;
using Microsoft.EntityFrameworkCore;

namespace Kinesis.Persistence
{
    public class KinesisContext : DbContext
    {
        public DbSet<StreamEntity> Streams { get; set; }

        public KinesisContext(DbContextOptions options)
            :base(options) 
        {
            
        }
    }
}