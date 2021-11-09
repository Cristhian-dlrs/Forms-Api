using System.Threading.Tasks;
using AutoMapper;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.Contracts.Services;
using FormsApp.Application.DTOs.Question;
using FormsApp.Application.Exceptions;
using FormsApp.Domain.Entities;

namespace FormsApp.Application.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public QuestionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<QuestionDto> CreateQuestion(CreateQuesitonDto createQuesitonDto)
        {
            var question = _mapper.Map<Question>(createQuesitonDto);
            question = await _unitOfWork.Questions.Add(question);
            await _unitOfWork.Save();
            var result = _mapper.Map<QuestionDto>(question);

            return result;
        }
        
        public async Task<bool> UpdateQuestion(UpdateQuestonDto questionDto)
        {
            var question = await _unitOfWork.Questions.Get(questionDto.Id);
            if (question == null)
                throw new BusinessException("Question not found.");

            question.Value = questionDto.Value;
            _unitOfWork.Questions.Update(question);
            await _unitOfWork.Save();
            return true;
        }
        
        public async Task<bool> DeleteQuesiton(int id)
        {
            var isValidId = await _unitOfWork.Questions.Exists(id);
            if (!isValidId)
                throw new BusinessException("Question not found.");
            
            await _unitOfWork.Questions.Delete(id);
            await _unitOfWork.Save();
            return true;
        }
    }
}