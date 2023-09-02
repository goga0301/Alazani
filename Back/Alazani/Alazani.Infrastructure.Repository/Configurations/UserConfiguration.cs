using Alazani.Domain.Entities;
using Alazani.Infrastructure.Repository.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alazani.Infrastructure.Repository.Configurations;

public class UserConfiguration : BaseEntityConfiguration<User, int>
{
    public override void ConfigureEntity(EntityTypeBuilder<User> builder)
    {
        builder.Property(x => x.FirstName).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
        builder.Property(x => x.LastName).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
        builder.Property(x => x.UserName).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
        builder.Property(x => x.Password).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
        builder.Property(x => x.PrivateNumber).HasColumnType("varchar(11)").HasMaxLength(11).IsRequired();
        builder.Property(x => x.PhoneNumber).HasColumnType("varchar(20)").HasMaxLength(20).IsRequired();
        builder.Property(x => x.EmailAddress).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
        builder.Property(x => x.Address).HasColumnType("varchar(100)").HasMaxLength(100).IsRequired();
        builder.Property(x => x.BirthDate).HasColumnType("timestamp").IsRequired();
        builder.Property(x => x.StartDate).HasColumnType("timestamp").IsRequired();
        builder.Property(x => x.EndDate).HasColumnType("timestamp");
        builder.Property(x => x.Status).HasColumnType("integer").IsRequired();

        builder.Property(x => x.RoleId).HasColumnType("bigint").IsRequired();
        builder.Property(x => x.OrganizationId).HasColumnType("bigint").IsRequired();


        builder.HasOne(x => x.Role).WithMany(x => x.Users).HasForeignKey(x => x.RoleId).HasConstraintName("FK_Role_Users");

        builder.HasIndex(x => x.PrivateNumber).IsUnique();
        builder.HasIndex(x => x.UserName).IsUnique();
        builder.HasIndex(x => x.EmailAddress).IsUnique();
        builder.HasIndex(x => x.PhoneNumber).IsUnique();

        builder.HasIndex(x => x.RoleId);
        builder.HasIndex(x => x.OrganizationId);
        builder.HasIndex(x => x.Status);



    }
}
