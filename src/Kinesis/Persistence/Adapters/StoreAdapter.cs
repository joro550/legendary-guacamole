using Kinesis.Persistence.Stores;

namespace Kinesis.Persistence.Adapters
{
    public class StoreAdapter : KinesisStore
    {
        private readonly KinesisContext _context;

        public StoreAdapter(KinesisContext context)
        {
            _context = context;
        }

        public override IStreamStore GetStreamStore() 
            => new StreamStore();

        public override IShardStore GetShardStore()
        {
            return new ShardStore();
        }
    }
}