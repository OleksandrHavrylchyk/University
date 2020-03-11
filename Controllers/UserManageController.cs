using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using University.Interfaces;
using University.Migrations;
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
        //[Authorize(Roles = "Administrator")]
        public async Task<ActionResult> SubscribeOnCourse([FromQuery]PagingUsersParameters userParameters)
        {
            var getPaginatedUsers = await userManageService.GetUsersAsync(userParameters);

            if(getPaginatedUsers.Users.Any())
            {
                return Ok(getPaginatedUsers);
            }

            return NoContent();
        }
    }
}
