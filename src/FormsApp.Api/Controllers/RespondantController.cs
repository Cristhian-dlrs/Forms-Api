using System.Collections.Generic;
using System.Threading.Tasks;
using FormsApp.Application.Contracts.Services;
using FormsApp.Application.DTOs.Respondant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormsApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RespondantController : ControllerBase
    {
        private readonly IRespondantService _respondantService;

        public RespondantController(IRespondantService respondantService)
        {
            _respondantService = respondantService;
        }
        
        [HttpGet("{formId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<RespondantDto>>> GetRespondants(int formId)
        {
            var result = await _respondantService.GetRespondants(formId);
            return Ok(result);
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<RespondantDto>> CreateRespondant(CreateRespondantDto respondantDto)
        {
            var result = await _respondantService.CreateRespondant(respondantDto);
            return Ok(result);
        }
    }
}