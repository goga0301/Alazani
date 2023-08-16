using Alazani.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Infrastructure.Repository.Configurations.Base;

namespace Alazani.Infrastructure.Repository.Configurations;

public class OrganizationConfiguration : BaseEntityConfiguration<Organization, int>
{
    public override void ConfigureEntity(EntityTypeBuilder<Organization> builder)
    {
        builder.Property(x => x.Name).HasColumnType("varchar(100)").HasMaxLength(100).IsRequired();
        builder.Property(x => x.Description).HasColumnType("varchar(500)").HasMaxLength(500).IsRequired();
        builder.Property(x => x.Address).HasColumnType("varchar(200)").HasMaxLength(200).IsRequired();

        builder.HasMany(x => x.Users).WithOne().HasForeignKey(x => x.OrganizationId).HasConstraintName("FK_Org_Users");
        builder.HasMany(x => x.Roles).WithOne().HasForeignKey(x => x.OrganizationId).HasConstraintName("FK_Org_Roles");
        builder.HasMany(x => x.Products).WithOne().HasForeignKey(x => x.OrganizationId).HasConstraintName("FK_Org_Products");
        builder.HasMany(x => x.Categories).WithOne().HasForeignKey(x => x.OrganizationId).HasConstraintName("FK_Org_Categories");


        builder.HasIndex(x => x.Name).IsUnique();

    }
}
