using RestaurateGustov.DBContext;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Services
{
    public class EmpleadoService: IEmpleadoService
    {
        private readonly RestauranteGustovDbContext _dbContext;
        public EmpleadoService(RestauranteGustovDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Empleado> CreateEmpleado(Empleado entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Empleado> GetEmpleado(int id)
        {
            var Empleado = _dbContext.Empleado.FirstOrDefault(p => p.EmpleadoId == id);
            return Empleado;
        }
        public async Task<IList<Empleado>> GetEmpleadoList(int id)
        {
            var Empleado = _dbContext.Empleado.Where(p => p.EmpleadoId == id);
            return Empleado.ToList();
        }
    }
}
