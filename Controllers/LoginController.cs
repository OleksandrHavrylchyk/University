using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using University.Models;
using University.Interfaces;
using University.Migrations;
using System.Linq;
using System;

namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserManager<ApplicationUserEntity> userManager;
        private readonly IAuthentificationService authentificationService;
        private readonly ApplicationDbContext entityContext;
        private bool isSubscribedOncourses;


        public LoginController(UserManager<ApplicationUserEntity> userManager, IAuthentificationService authentificationService,
                                ApplicationDbContext entityContext)
        {
            this.userManager = userManager;
            this.authentificationService = authentificationService;
            this.entityContext = entityContext;
            isSubscribedOncourses = false;
        }
        [HttpPost("login")]
        public async Task<ActionResult> LoginUser(LoginModel loginUser)
        {
            if (!await authentificationService.ValidateUser(loginUser))
            {
                return Unauthorized();
            }

            var user = await userManager.FindByNameAsync(loginUser.UserName);
            if(entityContext.CourseSubscribers.Where(user => user.UserId.Contains(user.UserId)).ToList().Count > 0)
            {
                isSubscribedOncourses = true;
            }

            var token = await authentificationService.GenerateToken(loginUser);

            return Ok(new { Token = token, isSubscribedOnCourses = isSubscribedOncourses });
        }
    }
}
