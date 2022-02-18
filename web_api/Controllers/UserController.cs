using Chat_app_2._0;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser")]
        public User Get()
        {
            return new User { first_name = "test", gender = Gender.Male, id = 10, last_name = "test", username = "rd07", password = "password" };
        }
        
    }
}