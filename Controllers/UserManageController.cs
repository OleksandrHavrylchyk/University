using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using University.DatabaseEntities.Validators;
using University.Interfaces;
using University.Models;

namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class UserManageController : ControllerBase
    {
        private readonly IUserManageService userManageService;
        private readonly UserDtoValidator userDtoValidator;

        public UserManageController(IUserManageService userManageService)
        {
            this.userManageService = userManageService;
            userDtoValidator = new UserDtoValidator();
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
            ValidationResult validationResult = userDtoValidator.Validate(editedUser);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var updatedUser = await userManageService.EditUserAsync(editedUser);

            return CreatedAtAction("Updated", editedUser);
        }
    }
}
