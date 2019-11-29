using Newtonsoft.Json;

namespace Kinesis.Core.Handlers
{
    public interface IRequestHandler
    {
        IHandlerResponse Execute();
    }

    public abstract class BaseHandler<TInputModel> : IRequestHandler
    {
        protected TInputModel Model;

        protected BaseHandler(string bodyContent)
        {
            Model = JsonConvert.DeserializeObject<TInputModel>(bodyContent);
        }

        public abstract IHandlerResponse Execute();
    }
}