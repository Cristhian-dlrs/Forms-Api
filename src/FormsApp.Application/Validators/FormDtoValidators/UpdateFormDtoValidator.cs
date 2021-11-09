using FluentValidation;
using FormsApp.Application.DTOs.Form;

namespace FormsApp.Application.Validators.FormDtoValidators
{
    public class UpdateFormDtoValidator : AbstractValidator<UpdateFormDto>
    {
        public UpdateFormDtoValidator()
        {
            Include(new BaseDtoValidator());
            
            RuleFor(x => x.Name)
                .NotNull().WithMessage("{PropertyName} is required.")
                .MaximumLength(50)
                .WithMessage("{PropertyName} must be less than 50 characters long.");
        }
    }
}