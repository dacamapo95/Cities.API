using CityInfo.API.Entities.Security;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : Controller
    {
        [HttpPost("authenticate")]
        public ActionResult<string> Authenticate(
            AuthenticationRequestBody authenticationRequestBody)
        {

        }
    }
}
