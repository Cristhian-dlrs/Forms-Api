using System.Threading.Tasks;
using FormsApp.Application.Contracts.Services;
using FormsApp.Application.DTOs.Question;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormsApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<QuestionDto>> CreateQuestion(
            [FromBody] CreateQuesitonDto createQuestionDto)
        {
            var result = await _questionService.CreateQuestion(createQuestionDto);
            return Ok(result);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<bool>> UpdateQuestion(
            [FromBody] UpdateQuestonDto questionDto)
        {
            var result = await _questionService.UpdateQuestion(questionDto);
            return Ok(result);
        }
        
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<bool>> DeleteQuestion(int id)
        {
            var result = await _questionService.DeleteQuesiton(id);
            return Ok(result);
        }
    }
}