using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using University.Interfaces;
using University.Models;

namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class UserManageController : ControllerBase
    {
        private readonly IUserManageService userManageService;

        public UserManageController(IUserManageService userManageService)
        {
            this.userManageService = userManageService;
        }

        [HttpGet("get-users")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> GetUsersAsync([FromQuery]PagingUsersParameters userParameters)
        {
            var getPaginatedUsers = await userManageService.GetUsersAsync(userParameters);

            if(getPaginatedUsers.Users.Any())
            {
                return Ok(getPaginatedUsers);
            }

            return NoContent();
        }

        [HttpPut("update-user")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<ApplicationUserEntity>> UpdateUser(UserDtoModel editedUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedUser = await userManageService.EditUserAsync(editedUser);

            return CreatedAtAction("Updated", updatedUser);
        }
    }
}
