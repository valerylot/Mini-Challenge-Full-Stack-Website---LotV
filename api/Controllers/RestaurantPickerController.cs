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
    public class RestaurantPickerController : ControllerBase
    {
        private readonly IRestaurantPickerServices _restaurantPickerServices;
        public RestaurantPickerController(IRestaurantPickerServices restaurantPickerServices)
        {
            _restaurantPickerServices = restaurantPickerServices;
        }

        [HttpGet("{category}")]
        public IActionResult RestaurantPicker(int category)
        {
            string restaurant = _restaurantPickerServices.PickRestaurant(category);

            return Ok(new {Message = restaurant});
        }
    }
}