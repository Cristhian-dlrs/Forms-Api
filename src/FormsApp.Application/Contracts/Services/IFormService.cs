using System.Collections.Generic;
using System.Threading.Tasks;
using FormsApp.Application.DTOs.Form;

namespace FormsApp.Application.Contracts.Services
{
    public interface IFormService
    {
        Task<IEnumerable<FormDto>> GetAllForms(int userId);
        Task<FormDto> GetForm(int id);
        Task<FormDto> GetFormWithQuestions(int id);
        Task<FormDto> CreateForm(CreateFormDto createFormDto);
        Task<bool> UpdateForm(UpdateFormDto updateformDto);
        Task<bool> DeleteForm(int id);
    }
}