using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurateGustov.Models;
using RestaurateGustov.Services;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController: ControllerBase
    {
        private readonly IEmpleadoService _empleadoService;

        public EmpleadoController(IEmpleadoService empleadoService)
        {
            this._empleadoService = empleadoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Empleado>>> GetEmpleadosAsync()
        {
            try
            {
                var empleado = await _empleadoService.GetEmpleadosAsync();
                return Ok(empleado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{empleadoId:int}", Name = "GetEmpleado")]
        public async Task<ActionResult<Empleado>> GetEmpleadoByIdAsync(int empleadoId)
        {
            try
            {
                var empleado = await _empleadoService.GetEmpleadoByIdAsync(empleadoId);

                if (empleado != null) return Ok(empleado);

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("filterByRestaurant/{restaurantId:int}")]
        public async Task<ActionResult<List<Empleado>>> GetEmpleadosByRestaurantIdAsync(int restaurantId)
        {
            try
            {
                var empleado = await _empleadoService.GetEmpleadosByRestaurantIdAsync(restaurantId);

                if (empleado != null) return Ok(empleado);

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]        
        public async Task<ActionResult<Empleado>> AddEmpleadoAsync(Empleado empleado)
        {
            try
            {
                var savedEmpleado = await _empleadoService.AddEmpleadoAsync(empleado);
                return CreatedAtRoute("GetEmpleado", new { savedEmpleado.EmpleadoId }, savedEmpleado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
