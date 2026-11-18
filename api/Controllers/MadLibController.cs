using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly IMadLibServices _madLibServices;
        public MadLibController(IMadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpGet("{madlib1}/{madlib2}/{madlib3}/{madlib4}/{madlib5}/{madlib6}/{madlib7}/{madlib8}/{madlib9}/{madlib10}")]
        public IActionResult CreateMadLib(string madlib1, string madlib2, string madlib3, string madlib4, string madlib5, string madlib6, string madlib7, string madlib8, string madlib9, string madlib10)
        {
            string result = _madLibServices.CreateMadLib(madlib1, madlib2, madlib3, madlib4, madlib5, madlib6, madlib7, madlib8, madlib9, madlib10);

            return Ok(new { Message = result });
        }
    }
}