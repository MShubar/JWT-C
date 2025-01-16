using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyJWSApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [Authorize]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "You Hit me!! ";
        }
    }
}
