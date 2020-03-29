using FluentValidation;
using University.Models;


namespace University.DatabaseEntities.Validators
{
    public class UserDtoValidator : AbstractValidator<UserDtoModel> { 

            public UserDtoValidator()
            {
                RuleFor(user => user.Email).NotEmpty().EmailAddress().WithMessage("Email is not valid");
                RuleFor(user => user.Name).NotEmpty().WithMessage("Name can not be empty");
                RuleFor(user => user.LastName).NotEmpty().WithMessage("Last Name can not be empty");
                RuleFor(user => user.Age).NotEmpty().LessThanOrEqualTo(120).GreaterThanOrEqualTo(1).WithMessage("Age is not valid");
        }
    }
}
