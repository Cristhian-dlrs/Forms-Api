using FluentValidation;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.DTOs.Respondant;

namespace FormsApp.Application.Validators.RespondantDtoValidators
{
    public class CreateRespondantDtoValidator : AbstractValidator<CreateRespondantDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public CreateRespondantDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Include(new IRespondantDtoValidator(_unitOfWork));
        }
    }
}