using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Kinesis.Controllers
{
    [ApiController]
    [Route("")]
    public class KinesisController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> HandleAction()
        {
            var handler = await RequestFactory.GetHandler(Request);
            return Ok(handler.Execute());
        }
    }

    public class RequestFactory
    {
        public static async Task<IRequestHandler> GetHandler(HttpRequest request)
        {
            var headerValues = request.Headers["X-Amz-Target"];
            var bodyContent = await GetDocumentContents(request);
            var commandConfig = CommandConfig.Parse(headerValues.FirstOrDefault());


            return commandConfig.Name switch
            {
                "ListStreams" => (IRequestHandler) new ListStreamHandler(bodyContent),
                _ => new UnknownCommandHandler(),
            };
        }

        private static async Task<string> GetDocumentContents(HttpRequest request)
        {
            using var readStream = new StreamReader(request.Body, Encoding.UTF8);
            return await readStream.ReadToEndAsync();
        }
    }

    public class CommandConfig
    {
        public string Name { get; set; }
        public string Header { get; set; }

        public static CommandConfig Parse(string command)
        {
            var commandParts = command.Split(".");
            return new CommandConfig
            {
                Name = commandParts[1],
                Header = commandParts[0]
            };
        }
    }

    public abstract class BadHandler<TInputModel> : IRequestHandler
    {
        protected TInputModel _model;

        protected BadHandler(string bodyContent)
        {
            _model = JsonConvert.DeserializeObject<TInputModel>(bodyContent);
        }

        public abstract IHandlerResponse Execute();
    }

    public interface IRequestHandler
    {
        IHandlerResponse Execute();
    }

    public class ListStreamHandler : BadHandler<ListStreamModel>
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

    public class UnknownCommandHandler : IRequestHandler
    {
        public IHandlerResponse Execute()
        {
            throw new System.NotImplementedException();
        }
    }

    public class ListStreamModel
    {

    }

    public interface IHandlerResponse
    {

    }

    public class ListStreamResponse : IHandlerResponse
    {

    }

    public class NullInput
    {

    }

    public class NullResponse : IHandlerResponse
    {

    }
}