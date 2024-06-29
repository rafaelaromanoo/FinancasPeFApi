using Microsoft.AspNetCore.Mvc;
using Model.Dto;
using Model.Interface;

namespace FinancasPeFWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RespostaForumController(IRespostaForumService service) : Controller
    {
        private readonly IRespostaForumService _service = service;

        [HttpGet("ListarRespostaForum/{idForum}")]
        public async Task<IActionResult> ListarRespostaForum(int idForum)
        {
            try
            {
                return Ok(await _service.ListarRespostasForum(idForum));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AdicionarRespostaForum")]
        public async Task<IActionResult> AdicionarRespostaForum(AdicionarRespostaForumDto respostaDto)
        {
            try
            {
                return Ok(await _service.AdicionarRespostaForum(respostaDto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
