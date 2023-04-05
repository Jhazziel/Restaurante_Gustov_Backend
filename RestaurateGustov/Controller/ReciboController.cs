using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurateGustov.Models;
using RestaurateGustov.Services;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReciboController : ControllerBase
    {
        private readonly IReciboService _resiboService;

        public ReciboController(IReciboService resiboService)
        {
            this._resiboService = resiboService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Recibo>>> GetRecibosAsync()
        {
            try
            {
                var recibo = await _resiboService.GetRecibosAsync();
                return Ok(recibo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{reciboId:int}", Name = "GetRecibo")]
        public async Task<ActionResult<Recibo>> GetReciboByIdAsync(int reciboId)
        {
            try
            {
                var recibo = await _resiboService.GetReciboByIdAsync(reciboId);

                if (recibo != null) return Ok(recibo);

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Recibo>> AddReciboAsync(Recibo recibo)
        {
            try
            {
                var savedRecibo = await _resiboService.AddReciboAsync(recibo);
                return CreatedAtRoute("GetRecibo", new { savedRecibo.ReciboId }, savedRecibo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
