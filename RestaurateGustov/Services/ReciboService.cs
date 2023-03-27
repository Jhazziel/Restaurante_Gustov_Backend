using RestaurateGustov.DBContext;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Services
{
    public class ReciboService : IReciboService
    {
        private readonly RestauranteGustovDbContext _dbContext;
        public ReciboService(RestauranteGustovDbContext dbContext) { 
         this._dbContext = dbContext;
        }
        public async Task<Recibo> CreateRecibo(Recibo entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Recibo> GetRecibo(int id)
        {
            var recibo = _dbContext.Recibo.FirstOrDefault(p => p.ReciboId == id);
            return recibo;

        }
    }
}
