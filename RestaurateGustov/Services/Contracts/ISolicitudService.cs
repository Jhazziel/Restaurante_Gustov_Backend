using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface ISolicitudService
    {
        Task<List<Solicitud>> GetSolicitudesAsync();
        Task<Solicitud> GetSolicitudByIdAsync(int solicitudId);
        Task<Solicitud> AddSolicitudAsync(Solicitud solicitud);
        Task<List<Solicitud>> GetSolicitudesByEmpleadoId(int empleadoId);
    }
}
