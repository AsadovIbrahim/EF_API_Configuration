using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Practic.Entities
{
    public class UserDetails : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        //foreign key
        //[ForeignKey(nameof(User))]
        public int Asus { get; set; }

        //Navigation Property
        public User? User { get; set; }
    }
}
