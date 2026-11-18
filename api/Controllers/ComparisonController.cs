using System.Runtime.CompilerServices;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComparisonController : ControllerBase
    {
        private readonly IComparisonServices _comparisonServices;

        public ComparisonController(IComparisonServices comparisonServices)
        {
            _comparisonServices = comparisonServices;
        }


        [HttpGet("{numThree}/{numFour}")]

        public IActionResult Comparison (int numThree, int numFour)
        {
            string[] result = _comparisonServices.Comparison(numThree, numFour);
            return Ok(new 
            {
                messageOne = result[0],
                messageTwo = result[1]
            });
        }
    }
}