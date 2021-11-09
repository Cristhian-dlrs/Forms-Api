using FluentValidation;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.DTOs.Question;

namespace FormsApp.Application.Validators.QuestionDtoValidators
{
    public class QestionDtoValidator : AbstractValidator<QuestionDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public QestionDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Include(new BaseDtoValidator());
            Include(new IQuestionDtoValidator(_unitOfWork));
        }
    }
}