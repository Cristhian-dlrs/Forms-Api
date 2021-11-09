using System.Collections.Generic;
using System.Threading.Tasks;
using FormsApp.Application.Contracts.Services;
using FormsApp.Application.DTOs.Answer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormsApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService _answerService;

        public AnswerController(IAnswerService answerService)
        {
            _answerService = answerService;
        }
        
        [HttpGet("{quesitonId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<AnswerDto>>> GetAnswers(int quesitonId)
        {
            var result = await _answerService.GetAnswers(quesitonId);
            return Ok(result);
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<AnswerDto>> CreateAnswer([FromBody]CreateAnswerDto answerDto)
        {
            var result = await _answerService.CreateAnswer(answerDto);
            return Ok(result);
        }
    }
}