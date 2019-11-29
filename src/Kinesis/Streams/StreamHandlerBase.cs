using Kinesis.Persistence;
using Kinesis.Core.Handlers;
using Kinesis.Persistence.Stores;

namespace Kinesis.Streams
{
    public abstract class StreamHandlerBase<T> : BaseHandler<T>
    {
        protected IStreamStore StreamStore { get; }

        protected StreamHandlerBase(string bodyContent) 
            : base(bodyContent)
        {
            StreamStore = KinesisStore.Instance.GetStreamStore();
        }
    }
}