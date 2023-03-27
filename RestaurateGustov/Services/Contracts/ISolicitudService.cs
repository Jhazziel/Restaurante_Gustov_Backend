using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface ISolicitudService
    {
        Task<Solicitud> GetSolicitud(int id);
        Task<Solicitud> CreateRecibo(Solicitud entity);
    }
}
