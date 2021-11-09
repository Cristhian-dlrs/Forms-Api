using FluentValidation;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.DTOs.Question;

namespace FormsApp.Application.Validators.QuestionDtoValidators
{
    public class IQuestionDtoValidator : AbstractValidator<IQuestionDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public IQuestionDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.Value)
                .NotNull().WithMessage("{PropertyName} is required.")
                .MaximumLength(100)
                .WithMessage("{PropertyName} must be less than 100 characters long.");

            RuleFor(x => x.FormId)
                .GreaterThan(0).WithMessage("Invalid {PropertyName}.")
                .MustAsync(async (id, token) => await _unitOfWork.Forms.Exists(id))
                .WithMessage("{PropertyName} does not exist.");
        }
    }
}