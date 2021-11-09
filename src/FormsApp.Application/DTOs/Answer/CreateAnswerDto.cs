namespace FormsApp.Application.DTOs.Answer
{
    public class CreateAnswerDto : IAnswerDto 
    {
        public string Value { get; set; }
        public int QuestionId { get; set; }
        public int RespondantId { get; set; }
    }
}