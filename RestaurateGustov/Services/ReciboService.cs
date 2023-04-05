using Microsoft.EntityFrameworkCore;
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

        public async Task<Recibo> AddReciboAsync(Recibo recibo)
        {
            try
            {
                await _dbContext.Recibo.AddAsync(recibo);
                await _dbContext.SaveChangesAsync();
                return recibo;
            }

            catch
            {
                throw;
            }
        }

        public async Task<Recibo> GetReciboByIdAsync(int reciboId)
        {
            try
            {
                var recibo = await _dbContext.Recibo.Where(c => c.ReciboId == reciboId).FirstOrDefaultAsync();

                return recibo;
            }

            catch
            {
                throw;
            }
        }

        public async Task<List<Recibo>> GetRecibosAsync()
        {
            try
            {
                var recibos = await _dbContext.Recibo.ToListAsync();

                return recibos;
            }

            catch
            {
                throw;
            }
        }
    }
}
