using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface IRestaurantService
    {
        Task<List<Restaurant>> GetRestaurantesAsync();
        Task<Restaurant> GetRestaurantByIdASync(int restaurantId);
    }
}
