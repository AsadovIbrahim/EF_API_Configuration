using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Practic.Entities
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
        public ICollection<ProductOrder>? ProductOrders { get; set; }
    }
}
