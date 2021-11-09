using FluentValidation;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.DTOs.Form;

namespace FormsApp.Application.Validators.FormDtoValidators
{
    public class CreateFormDtoValidator : AbstractValidator<CreateFormDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public CreateFormDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Include(new IFormDtoValidator(_unitOfWork));
        }
    }
}