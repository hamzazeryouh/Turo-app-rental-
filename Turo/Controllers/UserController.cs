using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Turo.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok();
        }

    }
}
