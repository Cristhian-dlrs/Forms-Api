using FluentValidation;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.DTOs.Respondant;

namespace FormsApp.Application.Validators.RespondantDtoValidators
{
    public class RespondantDtoValidator : AbstractValidator<RespondantDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public RespondantDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Include(new BaseDtoValidator());
            Include(new IRespondantDtoValidator(_unitOfWork));
        }
    }
}