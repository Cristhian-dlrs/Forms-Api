using FluentValidation;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.DTOs.Respondant;

namespace FormsApp.Application.Validators.RespondantDtoValidators
{
    public class IRespondantDtoValidator : AbstractValidator<IRespondantDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public IRespondantDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.Name)
                .NotNull().WithMessage("{PropertyName} is required.")
                .MaximumLength(50)
                .WithMessage("{PropertyName} must be less than 50 characters long.");

            RuleFor(x => x.FormId)
                .GreaterThan(0).WithMessage("Invalid {PropertyName}.")
                .MustAsync(async (id, token) => await _unitOfWork.Forms.Exists(id))
                .WithMessage("{PropertyName} does not exist.");
        }
    }
}