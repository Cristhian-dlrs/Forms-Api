using System.Collections.Generic;
using FormsApp.Application.DTOs.Base;
using FormsApp.Application.DTOs.Question;

namespace FormsApp.Application.DTOs.Form
{
    public class FormDto : BaseDto, IFormDto
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        
        public ICollection<QuestionDto> Questions { get; set; }
    }
}