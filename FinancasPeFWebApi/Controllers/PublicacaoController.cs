using Microsoft.AspNetCore.Mvc;
using Model.Interface;

namespace FinancasPeFWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublicacaoController(IPublicacaoService service) : ControllerBase
    {
        private readonly IPublicacaoService _service = service;

        [HttpGet("ListarPublicacoes")]
        public async Task<IActionResult> ListarPublicacoes()
        {
            try
            {
                return Ok(await _service.ListarPublicacoes());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CurtirPublicacao")]
        public async Task<IActionResult> CurtirPublicacao(int idPublicacao)
        {
            try
            {
                return Ok(await _service.CurtirPublicacao(idPublicacao));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}