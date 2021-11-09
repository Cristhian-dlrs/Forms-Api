using FluentValidation;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.DTOs.Answer;

namespace FormsApp.Application.Validators.AnswerDtoValidators
{
    public class CreateAnswerValidator : AbstractValidator<CreateAnswerDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public CreateAnswerValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Include(new IAnswerDtoValidator(_unitOfWork));
        }
    }
}