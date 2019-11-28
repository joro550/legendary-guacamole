using Kinesis.Core;
using Kinesis.Core.Handlers;

namespace Kinesis.Streams
{
    public class ListStreamHandler : BaseHandler<ListStreamModel>
    {
        public ListStreamHandler(string bodyContent) 
            : base(bodyContent)
        {
        }

        public override IHandlerResponse Execute()
        {
            return null;
        }
    }
}