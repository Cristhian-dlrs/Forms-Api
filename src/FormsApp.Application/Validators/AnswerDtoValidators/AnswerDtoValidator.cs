using FluentValidation;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.DTOs.Answer;

namespace FormsApp.Application.Validators.AnswerDtoValidators
{
    public class AnswerDtoValidator : AbstractValidator<AnswerDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public AnswerDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Include(new BaseDtoValidator());
            Include(new IAnswerDtoValidator(_unitOfWork));
        }
    }
}