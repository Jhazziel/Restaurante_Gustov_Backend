using Microsoft.AspNetCore.Mvc;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [ApiController]
    [Route("api/Recibo")]
    public class ReciboController: ControllerBase
    {
        private readonly IReciboService _recibo;
        public ReciboController(IReciboService resivoService)
        { 
            _recibo = resivoService;
        }

        [HttpGet("getRecibo/{id}")]
        public async Task<ActionResult<Recibo>> GetReciboAsync(int id)
        {
            return await _recibo.GetRecibo(id);
        }

        //[HttpGet]
        //public async Task<ActionResult<int>> GetRecibo()
        //{
        //    return  5;
        //}

    }
}
