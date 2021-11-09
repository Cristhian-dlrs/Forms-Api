using System.Collections.Generic;
using System.Threading.Tasks;
using FormsApp.Application.DTOs.Respondant;

namespace FormsApp.Application.Contracts.Services
{
    public interface IRespondantService
    {
        Task<IEnumerable<RespondantDto>> GetRespondants(int formId);
        Task<RespondantDto> CreateRespondant(CreateRespondantDto createRespondantDto);
    }
}