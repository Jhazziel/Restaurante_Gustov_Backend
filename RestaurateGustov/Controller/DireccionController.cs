using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DireccionController : ControllerBase
    {
        private readonly IDireccionService _direccionService;
        public DireccionController(IDireccionService direccionService)
        {
            _direccionService = direccionService;
        }

        [HttpGet]
        public async Task<ActionResult<Direccion>> GetDireccionesAsync()
        {
            try
            {
                var direcciones = await _direccionService.GetDireccionesAsync();
                return Ok(direcciones);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{direccionId:int}")]
        public async Task<ActionResult<Direccion>> GetDireccionByIdAsync(int direccionId)
        {
            try
            {
                var Direccion = await _direccionService.GetDireccionByIdAsync(direccionId);

                if (Direccion != null) return Ok(Direccion);

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
