using Microsoft.AspNetCore.Mvc;

namespace TestApp
{
    [Route("/")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        private readonly IGreetingService _greetingService;

        public GreetingController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public string Index([FromQuery]string name)
        {
            return _greetingService.Greet(name);
        }
    }
}
