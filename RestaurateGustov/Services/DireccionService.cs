using Microsoft.EntityFrameworkCore;
using RestaurateGustov.DBContext;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Services
{
    public class DireccionService: IDireccionService
    {
        private readonly RestauranteGustovDbContext _dbContext;

        public DireccionService(RestauranteGustovDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Direccion> GetDireccionByIdAsync(int direccionId)
        {
            try
            {
                var direccion = await _dbContext.Direccion.Where(d => d.DireccionId == direccionId).FirstOrDefaultAsync();

                return direccion;
            }

            catch
            {
                throw;
            }
        }

        public async Task<List<Direccion>> GetDireccionesAsync()
        {
            try
            {
                var direcciones = await _dbContext.Direccion.ToListAsync();

                return direcciones;
            }

            catch
            {
                throw;
            }
        }
    }
}
