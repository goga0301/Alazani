﻿using Alazani.Domain.Entities;
using Alazani.Infrastructure.Repository.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alazani.Infrastructure.Repository.Configurations;

public class CategoryConfiguration : BaseEntityConfiguration<Category, int>
{
    public override void ConfigureEntity(EntityTypeBuilder<Category> builder)
    {

        builder.Property(x => x.Name).HasColumnType("varchar(100)").HasMaxLength(100).IsRequired();
        builder.Property(x => x.Description).HasColumnType("varchar(500)").HasMaxLength(500).IsRequired();

        builder.Property(x => x.OrganizationId).HasColumnType("bigint").IsRequired();
    }
}
