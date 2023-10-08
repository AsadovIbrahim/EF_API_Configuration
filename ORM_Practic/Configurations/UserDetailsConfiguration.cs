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
    public class UserDetailsConfiguration : IEntityTypeConfiguration<UserDetails>
    {
        public void Configure(EntityTypeBuilder<UserDetails> builder)
        {
            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Name")
                .HasDefaultValue("No Name");

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Surname")
                .HasDefaultValue("No Surname");

            builder.HasOne(p => p.User)
                 .WithOne(p => p.UserDetails)
                 .HasForeignKey<UserDetails>(p => p.Asus);
        }
    }
}
