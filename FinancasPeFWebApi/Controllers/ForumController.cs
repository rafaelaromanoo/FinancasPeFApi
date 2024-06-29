using Microsoft.AspNetCore.Mvc;
using Model.Dto;
using Model.Interface;

namespace FinancasPeFWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ForumController(IForumService service) : Controller
    {
        private readonly IForumService _service = service;

        [HttpGet("ListarForuns")]
        public async Task<ActionResult> ListarForuns()
        {
            try
            {
                return Ok(await _service.ListarForuns());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AdicionarForum")]
        public async Task<ActionResult> AdicionarForum(AdicionarForumDto adicionarForumDto)
        {
            try
            {
                return Ok(await _service.AdicionarForum(adicionarForumDto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CurtirForum")]
        public async Task<ActionResult> CurtirForum(int idForum)
        {
            try
            {
                return Ok(await _service.CurtirForum(idForum));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
