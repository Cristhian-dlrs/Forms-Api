using FluentValidation;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.DTOs.Answer;

namespace FormsApp.Application.Validators.AnswerDtoValidators
{
    public class IAnswerDtoValidator : AbstractValidator<IAnswerDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public IAnswerDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.Value)
                .NotNull().WithMessage("{PropertyName} is required.")
                .MaximumLength(100)
                .WithMessage("{PropertyName} must be less than 100 characters long.");
            
            RuleFor(x => x.QuestionId)
                .GreaterThan(0).WithMessage("Invalid {PropertyName}.")
                .MustAsync(async (id, token) => await _unitOfWork.Questions.Exists(id))
                .WithMessage("{PropertyName} does not exist.");
            
            RuleFor(x => x.RespondantId)
                .GreaterThan(0).WithMessage("Invalid {PropertyName}.")
                .MustAsync(async (id, token) => await _unitOfWork.Respondants.Exists(id))
                .WithMessage("{PropertyName} does not exist.");
        }
    }
}