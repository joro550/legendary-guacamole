using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kinesis.Controllers;
using Kinesis.Core.Handlers;
using Kinesis.Streams;
using Microsoft.AspNetCore.Http;

namespace Kinesis.Core
{
    public static class RequestFactory
    {
        public static async Task<IRequestHandler> GetHandler(HttpRequest request)
        {
            var headerValues = request.Headers["X-Amz-Target"];
            var bodyContent = await GetDocumentContents(request);
            var commandConfig = CommandConfig.Parse(headerValues.FirstOrDefault());

            return commandConfig.Name switch
            {
                "ListStreams" => (IRequestHandler) new ListStreamHandler(bodyContent),
                "CreateStream" => (IRequestHandler) new CreateStreamHandler(bodyContent),
                _ => new UnknownCommandHandler(),
            };
        }

        private static async Task<string> GetDocumentContents(HttpRequest request)
        {
            using var readStream = new StreamReader(request.Body, Encoding.UTF8);
            return await readStream.ReadToEndAsync();
        }
    }
}