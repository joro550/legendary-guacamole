namespace Kinesis.Core.Handlers
{
    public class UnknownCommandHandler : IRequestHandler
    {
        public IHandlerResponse Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}