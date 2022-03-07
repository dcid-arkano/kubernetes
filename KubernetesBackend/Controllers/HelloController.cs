using Microsoft.AspNetCore.Mvc;

namespace KubernetesBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        public HelloController()
        {

        }

        [HttpGet(Name = "GetHello")]
        public IActionResult Get()
        {
            return Ok("Saludos!");
        }
    }
}

