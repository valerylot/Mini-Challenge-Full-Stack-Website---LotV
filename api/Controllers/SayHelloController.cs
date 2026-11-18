using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {

        private readonly ISayHelloServices _sayHelloServices;

        public SayHelloController(ISayHelloServices sayHelloServices)
        {
            _sayHelloServices = sayHelloServices;
        }

        [HttpGet("{username}")]
        public IActionResult SayHello(string username)
        {
            string greeting = _sayHelloServices.SayHello(username);
            return Ok(new { Message = greeting });
        }
    }
}