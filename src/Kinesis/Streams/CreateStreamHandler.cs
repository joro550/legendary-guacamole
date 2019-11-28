using Kinesis.Core;
using Kinesis.Core.Handlers;
using Kinesis.Core.Models;

namespace Kinesis.Streams
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