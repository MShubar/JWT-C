using MyJWSApp.Api.Models;

namespace MyJWSApp.Api.Service
{
    public interface IAuthService
    {
         string GenerateTokenString(LoginUser user);
        Task<bool> Login(LoginUser user);
        Task<bool> RegisterUser(LoginUser user);
    }
}