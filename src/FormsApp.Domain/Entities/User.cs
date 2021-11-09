using System.Collections.Generic;
using FormsApp.Domain.Entities.Base;

#nullable disable

namespace FormsApp.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Forms = new HashSet<Form>();
        }
        
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Form> Forms { get; set; }
    }
}
