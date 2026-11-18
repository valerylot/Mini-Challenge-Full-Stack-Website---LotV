using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase
    {

        private readonly IMathServices _mathServices;

        //DI, ASP.NET Core passes in the IMathServices that we registered in our Program.cs
        //Everytime the controller 
        public MathController(IMathServices mathServices)
        {
            _mathServices = mathServices;
        }

        [HttpGet("addition/{numOne}/{numTwo}")]

        public IActionResult Addition(int numOne, int numTwo)
        {
            int sum = _mathServices.Addition(numOne, numTwo);
            return Ok(new { numOne, numTwo, Result = sum });
        }
    }
}