using Microsoft.EntityFrameworkCore;
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

        public async Task<Empleado> AddEmpleadoAsync(Empleado empleado)
        {
            try
            {
                await _dbContext.Empleado.AddAsync(empleado);
                await _dbContext.SaveChangesAsync();
                return empleado;
            }

            catch
            {
                throw;
            }
        }

        public async Task<Empleado> GetEmpleadoByIdAsync(int empleadoId)
        {
            try
            {
                var empleado = await _dbContext.Empleado.Where(c => c.EmpleadoId == empleadoId).FirstOrDefaultAsync();

                return empleado;
            }

            catch
            {
                throw;
            }
        }

        public async Task<List<Empleado>> GetEmpleadosAsync()
        {
            try
            {
                var empleados = await _dbContext.Empleado.ToListAsync();

                return empleados;
            }

            catch
            {
                throw;
            }
        }

        public async Task<List<Empleado>> GetEmpleadosByRestaurantIdAsync(int restaurantId)
        {
            try
            {
                var empleado = await _dbContext.Empleado.Where(c => c.RestaurantId == restaurantId).ToListAsync();

                return empleado;
            }

            catch
            {
                throw;
            }
        }
    }
}
