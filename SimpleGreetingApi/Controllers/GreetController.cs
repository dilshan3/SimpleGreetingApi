using Microsoft.AspNetCore.Mvc;
using SimpleGreetApi.Services;

namespace SimpleGreetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string name)
        {
            var service = new GreetService();
            return Ok(service.Greet(name));
        }
    }
}
