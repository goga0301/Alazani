using Alazani.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Infrastructure.Repository.Configurations.Base;

namespace Alazani.Infrastructure.Repository.Configurations;

public class ProductConfiguration : BaseEntityConfiguration<Product, int>
{
    public override void ConfigureEntity(EntityTypeBuilder<Product> builder)
    {

        builder.Property(x => x.Name).HasColumnType("varchar(100)").HasMaxLength(100).IsRequired();
        builder.Property(x => x.Description).HasColumnType("varchar(500)").HasMaxLength(500).IsRequired();
        builder.Property(x => x.Price).HasColumnType("numeric").IsRequired();
        builder.Property(x => x.Stock).HasColumnType("integer").IsRequired();

        builder.Property(x => x.CurrencyId).HasColumnType("bigint").IsRequired();
        builder.Property(x => x.CategoryId).HasColumnType("bigint").IsRequired();
        builder.Property(x => x.OrganizationId).HasColumnType("bigint").IsRequired();

        builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId).HasConstraintName("FK_Category_Products");
        builder.HasOne<Currency>().WithMany().HasForeignKey(x => x.CurrencyId).HasConstraintName("FK_Currency_Products");
    }
}
