using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alican.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test()
        {
            var context = HttpContext;
            throw new ArgumentException("hata");
            return Ok(new {Message="Api is working"});
        }
    }
}
