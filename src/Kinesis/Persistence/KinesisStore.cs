using Kinesis.Persistence.Stores;

namespace Kinesis.Persistence
{
    public abstract class KinesisStore
    {
        public static KinesisStore Instance { get; set; }

        public abstract IShardStore GetShardStore();
        public abstract IStreamStore GetStreamStore();
    }
}
