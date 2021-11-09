using FluentValidation;
using FormsApp.Application.DTOs.User;

namespace FormsApp.Application.Validators.UserValidators
{
    public class UserLoginDtoValidator : AbstractValidator<UserLoginDto>
    {
        public UserLoginDtoValidator()
        {
            Include(new IUserValidator());
            
            RuleFor(x => x.Password)
                .MinimumLength(6)
                .WithMessage("{PropertyName} must be atleast 6 characters long.")
                .MaximumLength(25)
                .WithMessage("{PropertyName} must be less than 25 characters long.");
        }
    }
}