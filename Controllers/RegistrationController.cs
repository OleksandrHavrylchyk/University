using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using AutoMapper;
using University.Migrations;
using University.Models;
using University.Services;
using Microsoft.Extensions.Configuration;

namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {    
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUserEntity> userManager;
        private readonly IMapper mapper;
        private readonly EmailValidatorService emailValidatorService;
        private readonly EmailSenderService emailService;

        public RegistrationController(UserManager<ApplicationUserEntity> userManager,
                            IMapper mapper,
                            ApplicationDbContext context,
                            IConfiguration applicationConfiguration)
        {
            this.context = context;
            this.userManager = userManager;
            this.mapper = mapper;
            this.emailValidatorService = new EmailValidatorService();
            emailService = new EmailSenderService(applicationConfiguration);
        }

        [HttpPost("registration")]
        public async Task<ActionResult<ApplicationUserEntity>> RegisterUser(RegistrationModel registerUserData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!emailValidatorService.ValidateEmail(registerUserData.Email))
            {
                return BadRequest("Invalid email");
            }

            var userIdentity = mapper.Map<ApplicationUserEntity>(registerUserData);
            var result = await userManager.CreateAsync(userIdentity, registerUserData.Password);

            if (!result.Succeeded)
            {
                return new BadRequestObjectResult(result.Errors);
            }

            await userManager.AddToRoleAsync(userIdentity, "User");
            await context.SaveChangesAsync();

            await SendConfirmEmailAsync(registerUserData);

            return CreatedAtAction("Registered", registerUserData);           
        }

        [HttpPost("send-confirmation")]
        public async Task SendConfirmEmailAsync(RegistrationModel registerUserData)
        {
            var userForConfirmation = userManager.FindByEmailAsync(registerUserData.Email).Result;
            var confirmationToken = await userManager.GenerateEmailConfirmationTokenAsync(userForConfirmation);

            var callbackUrl = Url.Action(
                    "ConfirmEmail",
                    "EmailConfirmation",
                    new { userId = userForConfirmation.Id, code = confirmationToken },
                    protocol: HttpContext.Request.Scheme);

            await emailService.SendEmailAsync(userForConfirmation.Email, "Confirm your account",
                        $"Confirm registration by clicking on the link: <a href='{callbackUrl}'>{callbackUrl}</a>");
        }
    }
}
    