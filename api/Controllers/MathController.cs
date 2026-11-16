using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase
    {
        [HttpGet("addition/{numOne}/{numTwo}")]

        public IActionResult Addition(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return Ok(new { numOne, numTwo, Result = sum });
        }
    }
}