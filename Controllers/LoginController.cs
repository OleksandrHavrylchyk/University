using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using University.Models;
using University.Interfaces;
using University.Migrations;
using System.Linq;
using System.Security.Claims;

namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserManager<ApplicationUserEntity> userManager;
        private readonly IAuthenticationService authenticationService;
        private readonly IFacebookAuthenticationService facebookAuthenticationService;
        private readonly ApplicationDbContext entityContext;
        private readonly AuthorizedUserModel authorizedUserModel;

        public LoginController(UserManager<ApplicationUserEntity> userManager, IAuthenticationService authentificationService,
                                ApplicationDbContext entityContext, IFacebookAuthenticationService facebookAuthenticationService)
        {
            this.facebookAuthenticationService = facebookAuthenticationService;
            this.userManager = userManager;
            this.authenticationService = authentificationService;
            this.entityContext = entityContext;
            authorizedUserModel = new AuthorizedUserModel();
        }

        [HttpPost("login")]
        public async Task<ActionResult> LoginUser(LoginModel loginUser)
        {
            if (!await authenticationService.ValidateUser(loginUser))
            {
                return Unauthorized("Invalid user data");
            }

            var user = await userManager.FindByNameAsync(loginUser.UserName);
            if (!user.EmailConfirmed)
            {
                return BadRequest("Email is not confirmed");
            }

            var authorizedUser = authenticationService.LoginUser(user).Result;
            if (entityContext.CourseSubscribers.Where(courseSubscribers => courseSubscribers.UserId.Contains(user.Id)).ToList().Count > 0)
            {
                authorizedUser.IsSubscribedOncourses = true;
            }

            return Ok(authorizedUser);
        }

        [HttpPost("facebook-login")]
        public async Task<ActionResult> FacebookLoginUser(FacebookLoginModel facebookUser)
        {
            var isTokenValid = facebookAuthenticationService.ValidateFacebookToken(facebookUser);
            if (!isTokenValid.Result)
            {
                return BadRequest("Invalid facebook token");
            }

            if (userManager.FindByEmailAsync(facebookUser.Email).Result == null)
            {
                await facebookAuthenticationService.RegisterFacebookUser(facebookUser);
            }

            var authorizedFacebookUser = facebookAuthenticationService.LoginFacebookUser(facebookUser).Result;
            if (entityContext.CourseSubscribers.Where(user => user.UserId.Contains(user.UserId)).ToList().Count > 0)
            {
                authorizedFacebookUser.IsSubscribedOncourses = true;
            }

            return Ok(authorizedFacebookUser);
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken(RefreshTokenModel refreshTokenModel)
        {
            var principal = authenticationService.GetPrincipalFromExpiredToken(refreshTokenModel.Token);
            var userEmail = principal.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Email).Value;
            var userIdentity = await userManager.FindByEmailAsync(userEmail);

            var newJwtToken = await authenticationService.GenerateToken(userEmail);
            var newRefreshToken = authenticationService.GenerateRefreshToken();

            if (refreshTokenModel.RefreshToken != userManager.GetAuthenticationTokenAsync(userIdentity, "UniversityApp", "RefreshToken").Result)
            {
                return BadRequest("Invalid refresh token");
            }

            await userManager.RemoveAuthenticationTokenAsync(userIdentity, "UniversityApp", "RefreshToken");
            await userManager.SetAuthenticationTokenAsync(userIdentity, "UniversityApp", "RefreshToken", newRefreshToken);

            return Ok(new AuthorizedUserModel {
                Token = newJwtToken,
                RefreshToken = newRefreshToken
            });
        }
    }
}
