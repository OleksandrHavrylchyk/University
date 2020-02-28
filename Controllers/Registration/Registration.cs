﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using AutoMapper;
using University.Data;
using University.Models;
using University.PageViewModel;

namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class Registration : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public Registration(UserManager<ApplicationUser> userManager, IMapper mapper, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
        }
        // POST: api/registration
        [HttpPost("registration")]
        public async Task<ActionResult<ApplicationUser>> RegisterUser(RegistrationModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (_userManager.FindByEmailAsync(model.Email).Exception == null)
            {
                var userIdentity = _mapper.Map<ApplicationUser>(model);
                var result = await _userManager.CreateAsync(userIdentity, model.Password);

                if (!result.Succeeded) return new BadRequestObjectResult(result);

                await _context.SaveChangesAsync();

                return CreatedAtAction("Registered", model);
            }
            else
            {
                RegisterError response = new RegisterError
                {
                    Code = "DuplicateEmail",
                    Description = "Email " + model.Email + " is already taken"
                };
                return BadRequest(response);
            }
        }
    }
}
