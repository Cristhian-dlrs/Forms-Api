using FormsApp.Domain.Entities.Base;

#nullable disable

namespace FormsApp.Domain.Entities
{
    public class Answer : BaseEntity
    {
        public string Value { get; set; }
        public int QuestionId { get; set; }
        public int RespondantId { get; set; }

        public virtual Question Question { get; set; }
        public virtual Respondant Respondant { get; set; }
    }
}
