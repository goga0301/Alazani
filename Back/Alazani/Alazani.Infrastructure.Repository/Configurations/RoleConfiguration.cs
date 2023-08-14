using Alazani.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Infrastructure.Repository.Configurations.Base;

namespace Alazani.Infrastructure.Repository.Configurations;

public class RoleConfiguration : BaseEntityConfiguration<Role, int>
{
    public override void ConfigureEntity(EntityTypeBuilder<Role> builder)
    {
        builder.Property(x => x.Name).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
        builder.Property(x => x.Description).HasColumnType("varchar(300)").HasMaxLength(300).IsRequired();

        builder.Property(x => x.OrganizationId).HasColumnType("bigint").IsRequired();


        builder.HasIndex(x => x.OrganizationId);
    }
}
