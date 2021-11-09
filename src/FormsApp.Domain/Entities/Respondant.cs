using System.Collections.Generic;
using FormsApp.Domain.Entities.Base;

#nullable disable

namespace FormsApp.Domain.Entities
{
    public class Respondant : BaseEntity
    {
        public Respondant()
        {
            Answers = new HashSet<Answer>();
        }
        
        public string Name { get; set; }
        public int FormId { get; set; }

        public virtual Form Form { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
