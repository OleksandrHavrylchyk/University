using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;


namespace University.Controllers
{
    public class EmailConfirmationController : ControllerBase
    {
        private readonly UserManager<ApplicationUserEntity> userManager;
        public EmailConfirmationController(UserManager<ApplicationUserEntity> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IActionResult> ConfirmEmail([FromQuery(Name = "userId")]string userId, [FromQuery(Name = "code")]string code)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return BadRequest();
            }

            var result = await userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                return RedirectToAction("/");
            }

            return BadRequest();
        }
    }
}
