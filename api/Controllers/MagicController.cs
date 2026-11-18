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
    public class MagicController : ControllerBase
    {
        private readonly IMagic8BallServices _magic8BallService;

        public MagicController(IMagic8BallServices magic8BallService)
        {
            _magic8BallService = magic8BallService;
        }

        [HttpGet]
        public IActionResult UniqueResponses()
        {
            string response = _magic8BallService.UniqueResponses();

            return Ok(new { Message = response });
        }
    }
}