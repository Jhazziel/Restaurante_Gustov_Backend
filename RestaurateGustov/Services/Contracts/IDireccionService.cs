using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface IDireccionService
    {
        Task<Direccion> GetDireccion(int id);
        Task<Direccion> CreateDireccion(Direccion entity);
        Task<IList<Direccion>> GetDireccionList(int id);
    }
}
