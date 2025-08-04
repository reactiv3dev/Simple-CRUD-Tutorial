

using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    [ApiController]
    [Route("/api/users")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello there");
        }
    }
}

