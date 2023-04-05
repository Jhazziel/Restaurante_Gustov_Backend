using Microsoft.EntityFrameworkCore;
using RestaurateGustov.DBContext;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Services
{
    public class VacacionService : IVacacionService
    {
        private readonly RestauranteGustovDbContext _dbContext;

        public VacacionService(RestauranteGustovDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<Vacacion> AddVacacionAsync(Vacacion vacacion)
        {
            try
            {
                await _dbContext.Vacacion.AddAsync(vacacion);
                await _dbContext.SaveChangesAsync();
                return vacacion;
            }

            catch
            {
                throw;
            }
        }

        public async Task<List<Vacacion>> GetVacacionesAsync()
        {
            try
            {
                var vacaciones = await _dbContext.Vacacion.ToListAsync();

                return vacaciones;
            }

            catch
            {
                throw;
            }
        }

        public async Task<Vacacion> GetVacacionByIdAsync(int vacacionId)
        {
            try
            {
                var vacacion = await _dbContext.Vacacion.Where(c => c.VacacionId == vacacionId).FirstOrDefaultAsync();

                return vacacion;
            }

            catch
            {
                throw;
            }
        }
    }
}
