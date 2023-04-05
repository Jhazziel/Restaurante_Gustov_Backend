using Microsoft.EntityFrameworkCore;
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

        public async Task<Solicitud> AddSolicitudAsync(Solicitud solicitud)
        {
            try
            {
                await _dbContext.Solicitud.AddAsync(solicitud);
                await _dbContext.SaveChangesAsync();
                return solicitud;
            }

            catch
            {
                throw;
            }
        }

        public async Task<Solicitud> GetSolicitudByIdAsync(int solicitudId)
        {
            try
            {
                var solicitud = await _dbContext.Solicitud.Where(d => d.SolicitudId == solicitudId).FirstOrDefaultAsync();

                return solicitud;
            }

            catch
            {
                throw;
            }
        }

        public async Task<List<Solicitud>> GetSolicitudesAsync()
        {
            try
            {
                var solicitudes = await _dbContext.Solicitud.ToListAsync();

                return solicitudes;
            }

            catch
            {
                throw;
            }
        }

        public async Task<List<Solicitud>> GetSolicitudesByEmpleadoId(int empleadoId)
        {
            try
            {
                var solicitudes = await _dbContext.Solicitud.Where(d => d.EmpleadoId == empleadoId).ToListAsync();

                return solicitudes;
            }

            catch
            {
                throw;
            }
        }
    }
}
