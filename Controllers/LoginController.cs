using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using University.Models;


namespace University.Controllers.LoginLogout
{
    [Route("api/")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly SignInManager<ApplicationUserEntity> _signInManager;
        private readonly UserManager<ApplicationUserEntity> _userManager;

        public LoginController(SignInManager<ApplicationUserEntity> signInManager, UserManager<ApplicationUserEntity> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        // POST: api/login
        [HttpPost("login")]
        public async Task<ActionResult<ApplicationUserEntity>> LoginUser(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _signInManager.PasswordSignInAsync(model.UserName,
                                   model.Password, isPersistent:false, lockoutOnFailure: true);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                return CreatedAtAction("Logged into the system", user);
            }
            else
            {
                ModelState.AddModelError("error", "Invalid login attempt.");
                return BadRequest(ModelState);
            }
        }
        // POST: api/logout
        [HttpPost("logout")]
        public async Task<ActionResult<ApplicationUserEntity>> LogoutUser(LoginModel model)
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }
    }
}
