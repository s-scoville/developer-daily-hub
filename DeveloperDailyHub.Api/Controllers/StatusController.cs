using DeveloperDailyHub.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperDailyHub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public ActionResult<StatusResponse> GetStatus()
        {
            return Ok(new StatusResponse
            {
                Name = "DeveloperDailyHub API",
                Version = "v1.0",
                ServerTime = DateTime.UtcNow
            });
        }
    }
}
