using System.Collections.Generic;
using System.Threading.Tasks;
using FormsApp.Application.DTOs.Answer;

namespace FormsApp.Application.Contracts.Services
{
    public interface IAnswerService
    {
        Task<IEnumerable<AnswerDto>> GetAnswers(int questionId);
        Task<AnswerDto> CreateAnswer(CreateAnswerDto createAnswer);
    }
}