using FluentValidation;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.DTOs.Question;

namespace FormsApp.Application.Validators.QuestionDtoValidators
{
    public class CreateQuesitonDtoValidator : AbstractValidator<CreateQuesitonDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public CreateQuesitonDtoValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Include(new IQuestionDtoValidator(_unitOfWork));
        }
    }
}