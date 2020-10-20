using Microsoft.AspNetCore.Mvc;

namespace Microservice.Second.Comtrollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [Route("healthcheck")]
        public IActionResult HealthCheck()
        {
            return Ok();
        }
    }
}
