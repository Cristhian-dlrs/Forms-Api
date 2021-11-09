namespace FormsApp.Application.DTOs.Question
{
    public class CreateQuesitonDto : IQuestionDto
    {
        public string Value { get; set; }
        public int FormId { get; set; }
    }
}