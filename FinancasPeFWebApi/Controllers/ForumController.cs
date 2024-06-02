using Microsoft.AspNetCore.Mvc;
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
    }
}
