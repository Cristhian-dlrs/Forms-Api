using FluentValidation;
using FormsApp.Application.DTOs.Question;

namespace FormsApp.Application.Validators.QuestionDtoValidators
{
    public class UpdateQuesitonDtoVaidator : AbstractValidator<UpdateQuestonDto>
    {
        public UpdateQuesitonDtoVaidator()
        {
            Include(new BaseDtoValidator());
            
            RuleFor(x => x.Value)
                .NotNull().WithMessage("{PropertyName} is required.")
                .MaximumLength(100)
                .WithMessage("{PropertyName} must be less than 100 characters long.");
        }
    }
}