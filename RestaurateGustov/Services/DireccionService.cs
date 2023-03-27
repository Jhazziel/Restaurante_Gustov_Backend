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

        public async Task<Direccion> CreateDireccion(Direccion entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Direccion> GetDireccion(int id)
        {
            var Direccion = _dbContext.Direccion.FirstOrDefault(p => p.DireccionId == id);
            return Direccion;
        }
        public async Task<IList<Direccion>> GetDireccionList(int id)
        {
            var Direccion = _dbContext.Direccion.Where(p => p.DireccionId == id);
            return Direccion.ToList();
        }
    }
}
