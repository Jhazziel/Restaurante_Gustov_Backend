using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurateGustov.Models;
using RestaurateGustov.Services;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController: ControllerBase
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            this._restaurantService = restaurantService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Restaurant>>> GetRestaurantesAsync()
        {
            try
            {
                var restaurant = await _restaurantService.GetRestaurantesAsync();
                return Ok(restaurant);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{restaurantId:int}")]
        public async Task<ActionResult<Restaurant>> GetRestaurantByIdASync(int restaurantId)
        {
            try
            {
                var restaurant = await _restaurantService.GetRestaurantByIdASync(restaurantId);

                if (restaurant != null) return Ok(restaurant);

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
