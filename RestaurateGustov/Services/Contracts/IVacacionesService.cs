using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface IVacacionesService
    {
        Task<Vacaciones> GetVacaciones(int id);
        Task<Vacaciones> CreateVacaciones(Vacaciones entity);
        Task<IList<Vacaciones>> GetVacacionesList(int id);
    }
}
