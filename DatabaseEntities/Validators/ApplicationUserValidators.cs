using FluentValidation;
using University.Models;


namespace University.DatabaseEntities.Validators
{
    public class ApplicationRegistrationUserValidator : AbstractValidator<RegistrationModel> { 

            public ApplicationRegistrationUserValidator()
            {
                RuleFor(user => user.UserName).NotEmpty();
                RuleFor(user => user.Email).NotEmpty().EmailAddress();
                RuleFor(user => user.Password).NotEmpty();
            }
    }
}
