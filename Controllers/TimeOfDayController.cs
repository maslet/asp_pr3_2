using Microsoft.AspNetCore.Mvc;
using usov_402_pr3_part2.Interfaces;

namespace usov_402_pr3_part2.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class TimeOfDayController : ControllerBase {
        private readonly ITimeOfDayService _timeOfDayService;

        public TimeOfDayController(ITimeOfDayService timeOfDayService) {
            _timeOfDayService = timeOfDayService;
        }

        [HttpGet]
        public IActionResult GetTimeOfDay() {
            var message = _timeOfDayService.GetTimeOfDayMessage();
            return Ok(message);
        }
    }

}
