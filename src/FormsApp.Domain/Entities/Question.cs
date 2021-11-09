using System.Collections.Generic;
using FormsApp.Domain.Entities.Base;

#nullable disable

namespace FormsApp.Domain.Entities
{
    public class Question : BaseEntity
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }
        
        public string Value { get; set; }
        public int FormId { get; set; }

        public virtual Form Form { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}

