namespace FormsApp.Application.DTOs.Answer
{
    public interface IAnswerDto
    {
        public string Value { get; set; }
        public int QuestionId { get; set; }
        public int RespondantId { get; set; }
    }
}