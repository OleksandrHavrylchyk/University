using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using University.Models;
using University.Interfaces;
using University.Migrations;
using System.Linq;
using AutoMapper;
using Newtonsoft.Json;

namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly HttpClient httpClient;
        private readonly UserManager<ApplicationUserEntity> userManager;
        private readonly IAuthentificationService authentificationService;
        private readonly IMapper mapper;
        private readonly ApplicationDbContext entityContext;
        private readonly AuthorizedUserModel authorizedUserModel;


        public LoginController(UserManager<ApplicationUserEntity> userManager, IAuthentificationService authentificationService,
                                ApplicationDbContext entityContext, IMapper mapper)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.authentificationService = authentificationService;
            this.entityContext = entityContext;
            authorizedUserModel = new AuthorizedUserModel();
            httpClient = new HttpClient();
        }
        [HttpPost("login")]
        public async Task<ActionResult> LoginUser(LoginModel loginUser)
        {
            if (!await authentificationService.ValidateUser(loginUser))
            {
                return Unauthorized("Invalid user data");
            }

            var user = await userManager.FindByNameAsync(loginUser.UserName);

            authorizedUserModel.Token = await authentificationService.GenerateToken(user.Email);
            authorizedUserModel.RefreshToken = authentificationService.GenerateRefreshToken();

            if (entityContext.CourseSubscribers.Where(user => user.UserId.Contains(user.UserId)).ToList().Count > 0)
            {
                authorizedUserModel.IsSubscribedOncourses = true;
            }

            return Ok(authorizedUserModel);
        }
        [HttpPost("facebook-login")]
        public async Task<ActionResult> FacebookLoginUser(FacebookLoginModel facebookUser)
        {
            if(userManager.FindByEmailAsync(facebookUser.Email).Result == null)
            {
                var userIdentity = mapper.Map<ApplicationUserEntity>(facebookUser);
                var result = await userManager.CreateAsync(userIdentity, "Zxcv_1234");
                if (!result.Succeeded)
                {
                    return new BadRequestObjectResult(result.Errors);
                }
                await userManager.AddToRoleAsync(userIdentity, "User");
            }

            var appAccessTokenResponse = await httpClient.GetStringAsync($"https://graph.facebook.com/oauth/access_token?client_id=2814753781954441&client_secret=837cc4ab983d8c9c4a51da9ed50e470b&grant_type=client_credentials");
            var appAccessToken = JsonConvert.DeserializeObject<FacebookAppAccessToken>(appAccessTokenResponse);
            var userAccessTokenValidationResponse = await httpClient.GetStringAsync($"https://graph.facebook.com/debug_token?input_token={facebookUser.Token}&access_token={appAccessToken.AccessToken}");
            var userAccessTokenValidation = JsonConvert.DeserializeObject<FacebookUserAccessTokenValidation>(userAccessTokenValidationResponse);

            if (!userAccessTokenValidation.Data.IsValid)
            {
                return BadRequest("Invalid facebook token");
            }

            var user = await userManager.FindByEmailAsync(facebookUser.Email);

            authorizedUserModel.RefreshToken = authentificationService.GenerateRefreshToken();
            authorizedUserModel.Token = await authentificationService.GenerateToken(user.Email);

            if (entityContext.CourseSubscribers.Where(user => user.UserId.Contains(user.UserId)).ToList().Count > 0)
            {
                authorizedUserModel.IsSubscribedOncourses = true;
            }

            return Ok(authorizedUserModel);
        }
        [HttpPost]
        public IActionResult Refresh(string token, string refreshToken)
        {
            /*var principal = authentificationService.GetPrincipalFromExpiredToken(token);
            var username = principal.Identity.;

            var newJwtToken = GenerateToken(principal.Claims);
            var newRefreshToken = GenerateRefreshToken();

            return new ObjectResult(new
            {
                token = newJwtToken,
                refreshToken = newRefreshToken
            });*/
        }
    }
}
