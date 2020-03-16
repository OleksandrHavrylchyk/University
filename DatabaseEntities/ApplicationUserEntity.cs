using FluentValidation;
using Microsoft.AspNetCore.Identity;
using System;
using University.Services;

namespace University
{
    public class ApplicationUserEntity : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime RegisteredDate { get; set; }
    }

    public class ApplicationUserValidator : AbstractValidator<ApplicationUserEntity>
    {
        public ApplicationUserValidator()
        {
            /*RuleFor(user => user.Name).NotEmpty();
            RuleFor(user => user.LastName).NotEmpty();
            RuleFor(user => user.Age).NotEmpty().LessThan(150).GreaterThan(0);
            RuleFor(user => user.RegisteredDate).GreaterThanOrEqualTo(DateTime.UtcNow);*/
        }
    }
}
