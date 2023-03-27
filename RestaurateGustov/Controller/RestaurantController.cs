using Microsoft.AspNetCore.Mvc;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [ApiController]
    [Route("api/Restaurant")]
    public class RestaurantController
    {
        private readonly IRestaurantService _restaurant;
        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurant = restaurantService;
        }

        [HttpGet("getRestaurant/{id}")]
        public async Task<ActionResult<Restaurant>> GetRestaurant(int id)
        {
            return await _restaurant.GetRestaurant(id);
        }
    }
}
