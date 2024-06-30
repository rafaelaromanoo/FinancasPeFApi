using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Helper;

namespace FinancasPeFWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TagController : Controller
    {
        [HttpGet("ListarTags")]
        public IActionResult ListarTags()
        {
            return Ok(Enum.GetValues(typeof(Tag))
                   .Cast<Tag>()
                   .Select(tag => tag.GetDescription()));
        }
    }
}
