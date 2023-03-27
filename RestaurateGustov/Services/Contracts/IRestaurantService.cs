using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface IRestaurantService
    {
        Task<Restaurant> GetRestaurant(int id);
        Task<Restaurant> CreateRestaurant(Restaurant entity);
        Task<IList<Restaurant>> GetRestaurantList(int id);
    }
}
