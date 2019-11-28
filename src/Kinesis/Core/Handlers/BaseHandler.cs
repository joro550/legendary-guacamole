using Newtonsoft.Json;

namespace Kinesis.Core.Handlers
{
    public interface IRequestHandler
    {
        IHandlerResponse Execute();
    }

    public abstract class BaseHandler<TInputModel> : IRequestHandler
    {
        protected TInputModel _model;

        protected BaseHandler(string bodyContent)
        {
            _model = JsonConvert.DeserializeObject<TInputModel>(bodyContent);
        }

        public abstract IHandlerResponse Execute();
    }
}