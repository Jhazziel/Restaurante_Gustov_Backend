using Microsoft.AspNetCore.Mvc;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [ApiController]
    [Route("api/Empleado")]
    public class EmpleadoController
    {
        private readonly IEmpleadoService _empleado;
        public EmpleadoController(IEmpleadoService empleadoService)
        {
            _empleado = empleadoService;
        }

        [HttpGet("getEmpleado/{id}")]
        public async Task<ActionResult<Empleado>> GetEmpleado(int id)
        {
            return await _empleado.GetEmpleado(id);
        }
    }
}
