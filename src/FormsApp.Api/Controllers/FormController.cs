using System.Collections.Generic;
using System.Threading.Tasks;
using FormsApp.Application.Contracts.Services;
using FormsApp.Application.DTOs.Form;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormsApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormController : ControllerBase
    {
        private readonly IFormService _formService;

        public FormController(IFormService formService)
        {
            _formService = formService;
        }

        [HttpGet("getAll/{userId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<FormDto>>> GetAllForms(int userId)
        {
            var result = await _formService.GetAllForms(userId);
            return Ok(result);
        }
        
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<FormDto>> GetForm(int id)
        {
            var result = await _formService.GetForm(id);
            return Ok(result);
        }
        
        [HttpGet("getWithQuestions/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<FormDto>> GetFormWithQuestions(int id)
        {
            var result = await _formService.GetFormWithQuestions(id);
            return Ok(result);
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<FormDto>> CreateForm([FromBody] CreateFormDto createFormDto)
        {
            var result = await _formService.CreateForm(createFormDto);
            return Ok(result);
        }
        
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<bool>> UpdateForm([FromBody] UpdateFormDto formDto)
        {
            var result = await _formService.UpdateForm(formDto);
            return Ok(result);
        }
        
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<bool>> DeleteForm(int id)
        {
            var result = await _formService.DeleteForm(id);
            return Ok(result);
        }
    }
}