namespace FormsApp.Application.DTOs.Respondant
{
    public class CreateRespondantDto : IRespondantDto
    {
        public string Name { get; set; }
        public int FormId { get; set; }
    }
}