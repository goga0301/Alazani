﻿using Alazani.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Infrastructure.Repository.Configurations.Base;

namespace Alazani.Infrastructure.Repository.Configurations
{
    public class OrganizationConfiguration : BaseEntityConfiguration<Organization, int>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Organization> builder)
        {
            builder.HasMany(x => x.Users).WithOne().HasForeignKey(x => x.OrganizationId);
            builder.HasMany(x => x.Roles).WithOne().HasForeignKey(x => x.OrganizationId);
            builder.HasMany(x => x.Products).WithOne().HasForeignKey(x => x.OrganizationId);
            builder.HasMany(x => x.Categories).WithOne().HasForeignKey(x => x.OrganizationId);

        }
    }
}