using Alazani.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Infrastructure.Repository.Configurations.Base;

namespace Alazani.Infrastructure.Repository.Configurations;

internal class CustomerConfiguration : BaseEntityConfiguration<Customer, int>
{
    public override void ConfigureEntity(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(x => x.FirstName).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
        builder.Property(x => x.LastName).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
        builder.Property(x => x.Password).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
        builder.Property(x => x.PhoneNumber).HasColumnType("varchar(20)").HasMaxLength(20).IsRequired();
        builder.Property(x => x.EmailAddress).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();

        
        builder.ToTable(t => t.HasCheckConstraint("CK_Customer_EmailAddress", "\"EmailAddress\" ~ '^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,4}$'"));
    }
}
