using Kinesis.Core.Handlers;
using Kinesis.Streams.Models;

namespace Kinesis.Streams.Handlers
{
    public class ListStreamHandler : StreamHandlerBase<ListStreamRequest>
    {
        public ListStreamHandler(string bodyContent) 
            : base(bodyContent)
        {

        }

        public ListStreamHandler(ListStreamRequest request)
            :base("")
        {
            
        }

        public override IHandlerResponse Execute()
        {
            return null;
        }
    }
}