using System.Collections.Generic;
using FormsApp.Application.DTOs.Answer;
using FormsApp.Application.DTOs.Base;

namespace FormsApp.Application.DTOs.Question
{
    public class QuestionDto : BaseDto, IQuestionDto
    {
        public string Value { get; set; }
        public int FormId { get; set; }
    }
}