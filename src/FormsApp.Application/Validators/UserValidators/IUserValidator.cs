using FluentValidation;
using FormsApp.Application.DTOs.User;

namespace FormsApp.Application.Validators.UserValidators
{
    public class IUserValidator : AbstractValidator<IUserDto>
    {
        public IUserValidator()
        {
            RuleFor(x => x.Email)
                .NotNull().WithMessage("{PropertyName} is required.")
                .MaximumLength(50)
                .WithMessage("{PropertyName} must be less than 50 characters long.")
                .EmailAddress()
                .WithMessage("{PropertyName} must be a valid email.");
        }
    }
}