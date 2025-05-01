using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;

namespace PP_NominasBack.Controllers.Shared
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new { status = "Healthy" });
    }
}
