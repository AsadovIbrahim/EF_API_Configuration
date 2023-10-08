using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Practic.Entities
{
    public class Order : BaseEntity
    {
        public string? Address { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
        public ICollection<ProductOrder>? ProductOrders { get; set; }
    }
}
