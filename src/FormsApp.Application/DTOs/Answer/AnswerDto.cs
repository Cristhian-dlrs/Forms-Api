using FormsApp.Application.DTOs.Base;

namespace FormsApp.Application.DTOs.Answer
{
    public class AnswerDto : BaseDto, IAnswerDto
    {
        public string Value { get; set; }
        public int QuestionId { get; set; }
        public int RespondantId { get; set; }
    }
}