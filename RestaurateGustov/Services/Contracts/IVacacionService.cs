using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface IVacacionService
    {
        Task<List<Vacacion>> GetVacacionesAsync();
        Task<Vacacion> GetVacacionByIdAsync(int vacacionId);
        Task<Vacacion> AddVacacionAsync(Vacacion vacacion);
    }
}
