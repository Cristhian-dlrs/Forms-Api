using FormsApp.Application.DTOs.Base;

namespace FormsApp.Application.DTOs.Respondant
{
    public class RespondantDto : BaseDto, IRespondantDto
    {
        public string Name { get; set; }
        public int FormId { get; set; }
    }
}