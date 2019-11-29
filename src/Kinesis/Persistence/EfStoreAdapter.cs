using Kinesis.Persistence.Adapters;
using Kinesis.Persistence.Stores;

namespace Kinesis.Persistence
{
    public class EfStoreAdapter : KinesisStore
    {
        private readonly KinesisContext _context;

        public EfStoreAdapter(KinesisContext context)
        {
            _context = context;
        }

        public override IStreamStore GetStreamStore() 
            => new EfStreamStore();
    }
}