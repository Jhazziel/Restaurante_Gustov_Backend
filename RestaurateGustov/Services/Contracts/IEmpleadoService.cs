using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface IEmpleadoService
    {
        Task<List<Empleado>> GetEmpleadosAsync();
        Task<Empleado> GetEmpleadoByIdAsync(int empleadoId);
        Task<Empleado> AddEmpleadoAsync(Empleado empleado);
        Task<List<Empleado>> GetEmpleadosByRestaurantIdAsync(int restaurantId);
    }
}
