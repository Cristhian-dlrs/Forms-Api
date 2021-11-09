using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.Contracts.Services;
using FormsApp.Application.DTOs.Respondant;
using FormsApp.Application.Exceptions;
using FormsApp.Domain.Entities;

namespace FormsApp.Application.Services
{
    public class RespondantService : IRespondantService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RespondantService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<RespondantDto>> GetRespondants(int formId)
        {
            var isValidId = await _unitOfWork.Questions.Exists(formId);
            if (!isValidId)
                throw new BusinessException("Form not found");

            var respondants = await _unitOfWork.Respondants.GetAll();
            respondants = respondants.Where(x => x.FormId == formId);
            var result = _mapper.Map<IEnumerable<RespondantDto>>(respondants);

            return result;
        }

        public async Task<RespondantDto> CreateRespondant(CreateRespondantDto createRespondantDto)
        {
            var respondant = _mapper.Map<Respondant>(createRespondantDto);
            respondant = await _unitOfWork.Respondants.Add(respondant);
            await _unitOfWork.Save();
            var result = _mapper.Map<RespondantDto>(respondant);

            return result;
        }
    }
}