using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alican.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("{age}")] // route params
        public IActionResult Test(string age)
        {
            var context = HttpContext;

            return Ok(new {Message="Api is working"});
        }
        [HttpPost]
        public IActionResult Create(ProductDto productDto)
        {
            return Ok();
        }
    }
}
public sealed record ProductDto(int Id,string Name);
