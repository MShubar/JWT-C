using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyJWSApp.Api.Models;
using MyJWSApp.Api.Service;

namespace MyJWSApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth; 
        public AuthController( IAuthService authService)
        {
            _auth = authService;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterUser(LoginUser user)
        {
            if( await _auth.RegisterUser(user))
            {
                return Ok("Success Done!");
            }
            return BadRequest("Something went wrong ");
        }


        [HttpPost("Login")]
        public async Task <IActionResult> Login (LoginUser user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
           if (await _auth.Login(user))
            {
                var tokenString =  _auth.GenerateTokenString(user);
                return Ok(tokenString);
            }
            return BadRequest("Something went wrong ");
        }
    }
}
