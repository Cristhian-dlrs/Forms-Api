namespace FormsApp.Application.DTOs.Form
{
    public class CreateFormDto : IFormDto
    {
        public string Name { get; set; }
        public int UserId { get; set; }
    }
}