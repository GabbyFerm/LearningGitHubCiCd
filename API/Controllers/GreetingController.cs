using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        private readonly IGreetingService _greetingService;

        public GreetingController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        // Added a comment to get changed file
        [HttpGet]
        public ActionResult Get() 
        {
            return Ok(_greetingService.GetGreeting());
        }
    }
}
