using ORM_Practic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Practic.Entities
{
    public class User : BaseEntity
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? RePassword { get; set; }

        public Roles Role { get; set; }

        public UserDetails? UserDetails { get; set; }
        public ICollection<Order>? Orders { get; set; }

    }

}
