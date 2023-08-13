using Alazani.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Infrastructure.Repository.Configurations.Base;

namespace Alazani.Infrastructure.Repository.Configurations;

public class TestConfiguration : BaseEntityConfiguration<Test, int>
{
    public override void ConfigureEntity(EntityTypeBuilder<Test> builder)
    {
        builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("varchar").HasMaxLength(90).IsRequired();
        
    }
}
