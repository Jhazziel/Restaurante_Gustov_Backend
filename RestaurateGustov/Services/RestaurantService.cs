using Microsoft.EntityFrameworkCore;
using RestaurateGustov.DBContext;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Services
{
    public class RestaurantService: IRestaurantService
    {
        private readonly RestauranteGustovDbContext _dbContext;
        public RestaurantService(RestauranteGustovDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Restaurant> GetRestaurantByIdASync(int restaurantId)
        {
            try
            {
                var restaurant = await _dbContext.Restaurant.Where(c => c.RestaurantId == restaurantId).FirstOrDefaultAsync();

                return restaurant;
            }

            catch
            {
                throw;
            }
        }

        public async Task<List<Restaurant>> GetRestaurantesAsync()
        {
            try
            {
                var restaurantes = await _dbContext.Restaurant.ToListAsync();

                return restaurantes;
            }

            catch
            {
                throw;
            }
        }
    }
}
