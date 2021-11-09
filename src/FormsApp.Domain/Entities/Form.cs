using System.Collections.Generic;
using FormsApp.Domain.Entities.Base;

#nullable disable

namespace FormsApp.Domain.Entities
{
    public class Form : BaseEntity
    {
        public Form()
        {
            Questions = new HashSet<Question>();
            Respondants = new HashSet<Respondant>();
        }

        public string Name { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Respondant> Respondants { get; set; }
    }
}
