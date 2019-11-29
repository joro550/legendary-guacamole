using Kinesis.Core.Handlers;
using Kinesis.Core.Models;
using Kinesis.Streams.Models;

namespace Kinesis.Streams.Handlers
{
    public class CreateStreamHandler : BaseHandler<CreateStreamModel>
    {
        public CreateStreamHandler(string bodyContent)
            : base(bodyContent)
        {
        }

        public override IHandlerResponse Execute()
        {
            return new NullResponse();
        }
    }
}