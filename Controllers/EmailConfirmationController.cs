using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using AutoMapper;
using University.Data;
using University.Models;
using System.Text.RegularExpressions;


namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class EmailConfirmationController : ControllerBase
    {
        private readonly UserManager<ApplicationUserEntity> userManager;
        public EmailConfirmationController(UserManager<ApplicationUserEntity> userManager)
        {
            this.userManager = userManager;
        }
        [HttpGet("email-comfirmation")]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return BadRequest();
            }
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return BadRequest();
            }
            var result = await userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
                return Ok();
            else
                return BadRequest();
        }
    }
}
