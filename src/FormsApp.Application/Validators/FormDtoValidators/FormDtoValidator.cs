using FluentValidation;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.DTOs.Form;

namespace FormsApp.Application.Validators.FormDtoValidators
{
    public class FormDtoValidator : AbstractValidator<FormDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public FormDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Include(new BaseDtoValidator());
            Include(new IFormDtoValidator(_unitOfWork));
        }
    }
}