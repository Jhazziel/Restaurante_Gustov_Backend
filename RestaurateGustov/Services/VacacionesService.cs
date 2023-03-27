using RestaurateGustov.DBContext;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Services
{
    public class VacacionesService: IVacacionesService
    {
        private readonly RestauranteGustovDbContext _dbContext;
        public VacacionesService(RestauranteGustovDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Vacaciones> CreateVacaciones(Vacaciones entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Vacaciones> GetVacaciones(int id)
        {
            var Vacaciones = _dbContext.Vacaciones.FirstOrDefault(p => p.VacacionesId == id);
            return Vacaciones;
        }
        public async Task<IList<Vacaciones>> GetVacacionesList(int id)
        {
            var Vacaciones = _dbContext.Vacaciones.Where(p => p.VacacionesId == id);
            return Vacaciones.ToList();
        }
    }
}
