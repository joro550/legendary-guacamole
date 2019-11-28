using Kinesis.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
}