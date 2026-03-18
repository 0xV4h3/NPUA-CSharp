using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Hello from API!" });
        }
    }
}
