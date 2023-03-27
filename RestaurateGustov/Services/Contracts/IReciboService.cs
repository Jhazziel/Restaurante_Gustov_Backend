using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface IReciboService
    {
        Task<Recibo> GetRecibo(int id);
        Task<Recibo> CreateRecibo(Recibo entity);
    }
}
