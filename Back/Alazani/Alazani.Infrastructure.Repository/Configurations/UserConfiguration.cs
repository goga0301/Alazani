using Alazani.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Infrastructure.Repository.Configurations.Base;

namespace Alazani.Infrastructure.Repository.Configurations;

public class UserConfiguration : BaseEntityConfiguration<User, int>
{
    public override void ConfigureEntity(EntityTypeBuilder<User> builder)
    {
        builder.HasOne<Role>().WithMany(x => x.Users).HasForeignKey(x => x.RoleId).HasConstraintName("FK_Role_Users") ;
    }
}
