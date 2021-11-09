using FluentValidation;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.DTOs.Form;

namespace FormsApp.Application.Validators.FormDtoValidators
{
    public class IFormDtoValidator : AbstractValidator<IFormDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public IFormDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            RuleFor(x => x.Name)
                .NotNull().WithMessage("{PropertyName} is required.")
                .MaximumLength(50)
                .WithMessage("{PropertyName} must be less than 50 characters long.");
            
            RuleFor(x => x.UserId)
                .GreaterThan(0).WithMessage("Invalid {PropertyName}.")
                .MustAsync(async (id, token) => await _unitOfWork.Users.Exists(id))
                .WithMessage("{PropertyName} does not exist.");
        }
    }
}