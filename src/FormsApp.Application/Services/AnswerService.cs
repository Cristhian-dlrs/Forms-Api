using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.Contracts.Services;
using FormsApp.Application.DTOs.Answer;
using FormsApp.Application.Exceptions;
using FormsApp.Domain.Entities;

namespace FormsApp.Application.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AnswerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AnswerDto>> GetAnswers(int questionId)
        {
            var isValidId = await _unitOfWork.Questions.Exists(questionId);
            if (!isValidId)
                throw new BusinessException("Quesiton not found");

            var answers = await _unitOfWork.Answers.GetAll();
            answers = answers.Where(x => x.QuestionId == questionId);
            var result = _mapper.Map<IEnumerable<AnswerDto>>(answers);

            return result;
        }

        public async Task<AnswerDto> CreateAnswer(CreateAnswerDto createAnswer)
        {
            var answer = _mapper.Map<Answer>(createAnswer);
            answer = await _unitOfWork.Answers.Add(answer);
            await _unitOfWork.Save();
            var result = _mapper.Map<AnswerDto>(answer);

            return result;
        }
    }
}