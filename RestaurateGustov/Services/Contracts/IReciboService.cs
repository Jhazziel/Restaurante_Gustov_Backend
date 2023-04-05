using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface IReciboService
    {
        Task<List<Recibo>> GetRecibosAsync();
        Task<Recibo> GetReciboByIdAsync(int reciboId);
        Task<Recibo> AddReciboAsync(Recibo recibo);
    }
}
