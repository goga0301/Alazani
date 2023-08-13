using Alazani.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Infrastructure.Repository.Configurations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alazani.Infrastructure.Repository.Configurations
{
    internal class CustomerConfiguration : BaseEntityConfiguration<Customer, int>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(x => x.FirstName).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
            builder.Property(x => x.LastName).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Password).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PhoneNumber).HasColumnType("varchar(20)").HasMaxLength(20).IsRequired();
            builder.Property(x => x.EmailAddress).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();

            // Add email validation using regular expression
            builder.Property(x => x.EmailAddress)
                   .HasAnnotation("RegularExpression", @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$")
                   .HasAnnotation("RegularExpressionErrorMessage", "Invalid email address format.");
        }
    }
}
