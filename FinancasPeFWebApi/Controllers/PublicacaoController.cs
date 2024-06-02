using Microsoft.AspNetCore.Mvc;

namespace FinancasPeFWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublicacaoController : ControllerBase
    {
        [HttpGet("Teste")]
        public async Task<ActionResult> Teste()
        {
            await Task.CompletedTask;
            return Ok();
        }
    }
}
