﻿using Alazani.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Infrastructure.Repository.Configurations.Base;

namespace Alazani.Infrastructure.Repository.Configurations;

public class ProductConfiguration : BaseEntityConfiguration<Product, int>
{
    public override void ConfigureEntity(EntityTypeBuilder<Product> builder)
    {
        builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId).HasConstraintName("FK_Category_Products");
        builder.HasOne<Currency>().WithMany().HasForeignKey(x => x.CurrencyId).HasConstraintName("FK_Currency_Products");
    }
}
