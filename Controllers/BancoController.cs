using System.ComponentModel.DataAnnotations;
using artigotech_integra_brasilapi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace artigotech_integra_brasilapi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancoController : ControllerBase
    {
        public readonly IBancoService _bancoService;

        public BancoController(IBancoService bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet("busca/todos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTodos() 
        {
            var response = await _bancoService.BuscarTodos();

            if(response.CodigoHttp == System.Net.HttpStatusCode.OK) 
            {
                return Ok(response.Objeto);
            }
            else 
            {
                return StatusCode((int)response.CodigoHttp, response.Body);
            }
        }

        [HttpGet("busca/{codigoBanco}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Buscar(string codigoBanco) 
        {
            var response = await _bancoService.BuscarBanco(codigoBanco);

            if(response.CodigoHttp == System.Net.HttpStatusCode.OK) 
            {
                return Ok(response.Objeto);
            }
            else 
            {
                return StatusCode((int)response.CodigoHttp, response.Body);
            }
        }
    }
}