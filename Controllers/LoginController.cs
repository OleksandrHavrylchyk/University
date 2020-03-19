using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using University.Models;
using University.Interfaces;
using University.Migrations;
using System.Linq;
using AutoMapper;

namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class LoginController : ControllerBase
    {
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
        }
        [HttpPost("login")]
        public async Task<ActionResult> LoginUser(LoginModel loginUser)
        {
            if (!await authentificationService.ValidateUser(loginUser))
            {
                return Unauthorized("Invalid user data");
            }

            var user = await userManager.FindByNameAsync(loginUser.UserName);
            var token = await authentificationService.GenerateToken(user.Email);
            authorizedUserModel.Token = token;

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

            var user = await userManager.FindByEmailAsync(facebookUser.Email);
            var token = await authentificationService.GenerateToken(user.Email);
            authorizedUserModel.Token = token;

            if (entityContext.CourseSubscribers.Where(user => user.UserId.Contains(user.UserId)).ToList().Count > 0)
            {
                authorizedUserModel.IsSubscribedOncourses = true;
            }

            return Ok(authorizedUserModel);
        }
    }
}
