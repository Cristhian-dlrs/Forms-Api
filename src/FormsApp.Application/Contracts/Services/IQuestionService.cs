using System.Threading.Tasks;
using FormsApp.Application.DTOs.Question;

namespace FormsApp.Application.Contracts.Services
{
    public interface IQuestionService
    {
        Task<QuestionDto> CreateQuestion(CreateQuesitonDto createQuesitonDto);
        Task<bool> UpdateQuestion(UpdateQuestonDto questionDto);
        Task<bool> DeleteQuesiton(int id);
    }
}