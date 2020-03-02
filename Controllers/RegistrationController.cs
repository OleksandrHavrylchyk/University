using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using AutoMapper;
using University.Data;
using University.Models;
using University.Services;


namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class Registration : ControllerBase
    {
        public List<ResponseErrorModel> errorResponse;

        public static string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUserEntity> userManager;
        private readonly IMapper mapper;

        public Registration(UserManager<ApplicationUserEntity> userManager, IMapper mapper, ApplicationDbContext context)
        {
            this.context = context;
            this.userManager = userManager;
            this.mapper = mapper;
            errorResponse = new List<ResponseErrorModel>();
        }

        [HttpPost("registration")]
        public async Task<ActionResult<ApplicationUserEntity>> RegisterUser(RegistrationModel registerUserData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Regex regualarExpressionEmailValidator = new Regex(emailRegex);
            if (!regualarExpressionEmailValidator.IsMatch(registerUserData.Email))
            {
                errorResponse.Add(new ResponseErrorModel
                {
                    Code = (int)ErrorCodes.InvalidEmail,
                    Description = "Please provide valid email "
                });
                return BadRequest(errorResponse);
            }

            if (userManager.FindByEmailAsync(registerUserData.Email).Exception == null)
            {
                var userIdentity = mapper.Map<ApplicationUserEntity>(registerUserData);
                var result = await userManager.CreateAsync(userIdentity, registerUserData.Password);

                if (!result.Succeeded)
                {
                    return new BadRequestObjectResult(result.Errors);
                }

                await SendConfirmEmailAsync(userIdentity);
                await context.SaveChangesAsync();

                return CreatedAtAction("Registered", registerUserData);
            }
           
             errorResponse.Add(new ResponseErrorModel
             {
                 Code = (int)ErrorCodes.DuplicateEmail,
                 Description = $"Email {registerUserData.Email} is already taken"
             });

             return BadRequest(errorResponse);           
        }
        public async Task SendConfirmEmailAsync(ApplicationUserEntity userIdentity)
        {
            var confirmationToken = await userManager.GenerateEmailConfirmationTokenAsync(userIdentity);
            var callbackUrl = Url.Action(
                    "ConfirmEmail",
                    "Account",
                    new { userId = userIdentity.Id, code = confirmationToken },
                    protocol: HttpContext.Request.Scheme);
            EmailSenderService emailService = new EmailSenderService();
            await emailService.SendEmailAsync(userIdentity.Email, "Confirm your account",
                        $"Confirm registration by clicking on the link: <a href='{callbackUrl}'>link</a>");
        }
    }
}
