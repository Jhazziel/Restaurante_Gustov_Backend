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

        public async Task<Restaurant> CreateRestaurant(Restaurant entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Restaurant> GetRestaurant(int id)
        {
            var Restaurant = _dbContext.Restaurant.FirstOrDefault(p => p.RestaurantId == id);
            return Restaurant;
        }
        public async Task<IList<Restaurant>> GetRestaurantList(int id)
        {
            var Restaurant = _dbContext.Restaurant.Where(p => p.RestaurantId == id);
            return Restaurant.ToList();
        }
    }
}
