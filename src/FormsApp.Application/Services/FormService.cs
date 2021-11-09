using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.Contracts.Services;
using FormsApp.Application.DTOs.Form;
using FormsApp.Application.Exceptions;
using FormsApp.Domain.Entities;

namespace FormsApp.Application.Services
{
    public class FormService : IFormService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FormService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FormDto>> GetAllForms(int userId)
        {
            var isValidId = await _unitOfWork.Users.Exists(userId);
            if (!isValidId)
                throw new BusinessException("User not found");
            
            var forms = await _unitOfWork.Forms.GetAll();
            forms = forms.Where(x => x.UserId == userId);
            var result = _mapper.Map<IEnumerable<FormDto>>(forms);

            return result;
        }

        public async Task<FormDto> GetForm(int id)
        {
            var isValidId = await _unitOfWork.Forms.Exists(id);
            if (!isValidId)
                throw new BusinessException("Form not found.");

            var form = await _unitOfWork.Forms.Get(id);
            var result = _mapper.Map<FormDto>(form);

            return result;
        }
        
        public async Task<FormDto> GetFormWithQuestions(int id)
        {
            var isValidId = await _unitOfWork.Forms.Exists(id);
            if (!isValidId)
                throw new BusinessException("Form not found.");

            var form = await _unitOfWork.Forms.GetFormWithQuesitons(id);
            var result = _mapper.Map<FormDto>(form);

            return result;
        }

        public async Task<FormDto> CreateForm(CreateFormDto createFormDto)
        {
            var form = _mapper.Map<Form>(createFormDto);
            form = await _unitOfWork.Forms.Add(form);
            await _unitOfWork.Save();
            var result = _mapper.Map<FormDto>(form);

            return result;
        }
        
        public async Task<bool> UpdateForm(UpdateFormDto formDto)
        {
            var form = await _unitOfWork.Forms.Get(formDto.Id);
            if (form == null)
                throw new BusinessException("Form not found.");

            form.Name = formDto.Name;
            _unitOfWork.Forms.Update(form);
            await _unitOfWork.Save();
            return true;
        }
        
        public async Task<bool> DeleteForm(int id)
        {
            var isValidId = await _unitOfWork.Forms.Exists(id);
            if (!isValidId)
                throw new BusinessException("Form not found.");
            
            await _unitOfWork.Forms.Delete(id);
            await _unitOfWork.Save();
            return true;
        }
    }
}