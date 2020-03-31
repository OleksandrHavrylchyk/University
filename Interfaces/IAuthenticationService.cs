using System.Security.Claims;
using System.Threading.Tasks;
using University.Models;

namespace University.Interfaces
{
    public interface IAuthenticationService
    {
        Task<bool> ValidateUser(LoginModel userForLogin);
        Task<string> GenerateToken(string email);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string expiresToken);
        Task<AuthorizedUserModel> LoginUser(ApplicationUserEntity userForLogin);
    }
}
