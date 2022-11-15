using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace hrweb.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
