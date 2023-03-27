using Microsoft.AspNetCore.Mvc;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [ApiController]
    [Route("api/Direccion")]
    public class DireccionController
    {
        private readonly IDireccionService _direccion;
        public DireccionController(IDireccionService direccionService)
        {
            _direccion = direccionService;
        }

        [HttpGet("getDireccion/{id}")]
        public async Task<ActionResult<Direccion>> GetDireccion(int id)
        {
            return await _direccion.GetDireccion(id);
        }
    }
}
