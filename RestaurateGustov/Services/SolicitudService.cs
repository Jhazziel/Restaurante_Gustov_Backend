using RestaurateGustov.DBContext;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Services
{
    public class SolicitudService: ISolicitudService
    {
        private readonly RestauranteGustovDbContext _dbContext;
        public SolicitudService(RestauranteGustovDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Solicitud> CreateRecibo(Solicitud entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Solicitud> GetSolicitud(int id)
        {
            var solicitud = _dbContext.Solicitud.FirstOrDefault(p => p.SolicitudId == id);
            return solicitud;
        }
    }
}
