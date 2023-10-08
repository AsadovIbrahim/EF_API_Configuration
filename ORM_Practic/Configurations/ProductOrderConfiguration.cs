using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ORM_Practic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Practic.Configurations
{
    public class ProductOrderConfiguration : IEntityTypeConfiguration<ProductOrder>
    {
        public void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            //builder.Ignore(p => p.Id);
            builder.Ignore(p => p.CreatedTime);
            builder.Ignore(p => p.ModifierTime);


            builder.HasOne(p => p.Product)
               .WithMany(p => p.ProductOrders)
               .HasForeignKey(p => p.ProductId);

            builder.HasOne(p => p.Order)
                .WithMany(p => p.ProductOrders)
                .HasForeignKey(p => p.OrderId);

        }
    }
}
