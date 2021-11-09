using FluentValidation;
using FormsApp.Application.DTOs.Base;

namespace FormsApp.Application.Validators
{
    public class BaseDtoValidator : AbstractValidator<BaseDto>
    {
        public BaseDtoValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage("Invalid {PropertyName}.");
        }
    }
}