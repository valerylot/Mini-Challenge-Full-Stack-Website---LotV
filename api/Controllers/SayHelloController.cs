using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpGet("{username}")]
        public IActionResult SayHello(string username)
        {
            return Ok(new { Message = "Hello " + username });
        }
    }
}