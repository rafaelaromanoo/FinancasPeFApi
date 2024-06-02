using Microsoft.AspNetCore.Mvc;
using Model.Interface;

namespace FinancasPeFWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublicacaoController(IPublicacaoService service) : ControllerBase
    {
        private readonly IPublicacaoService _service = service;

        [HttpGet("Teste")]
        public async Task<ActionResult> Teste()
        {
            return Ok(await _service.Teste());
        }
    }
}