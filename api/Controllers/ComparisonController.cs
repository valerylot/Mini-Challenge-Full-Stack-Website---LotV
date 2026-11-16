using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComparisonController : ControllerBase
    {
        [HttpGet("{numThree}/{numFour}")]

        public IActionResult Comparison (int numThree, int numFour)
        {
            if(numThree > numFour)
            {
                return Ok( new { Message = $"{numThree} is greater than {numFour}. {numFour} is less than {numThree}." });
            }else if(numThree < numFour)
            {
                return Ok( new { Message = $"{numThree} is less than {numFour}. {numFour} is greater than {numThree}." });
            }
            else
            {
                return Ok ( new { Message = $"{numThree} is equal to {numFour}." });
            }
        }
    }
}