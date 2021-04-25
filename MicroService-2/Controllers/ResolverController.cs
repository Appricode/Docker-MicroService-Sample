using Microsoft.AspNetCore.Mvc;

namespace MicroService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResolverController : ControllerBase
    {
        public ResolverController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("MicroService-2");
        }
    }
}
