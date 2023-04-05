using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface IDireccionService
    {
        Task<List<Direccion>> GetDireccionesAsync();
        Task<Direccion> GetDireccionByIdAsync(int direccionId);
        
    }
}
