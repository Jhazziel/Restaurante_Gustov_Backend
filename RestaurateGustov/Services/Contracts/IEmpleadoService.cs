using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface IEmpleadoService
    {
        Task<Empleado> GetEmpleado(int id);
        Task<Empleado> CreateEmpleado(Empleado entity);
        Task<IList<Empleado>> GetEmpleadoList(int id);
    }
}
