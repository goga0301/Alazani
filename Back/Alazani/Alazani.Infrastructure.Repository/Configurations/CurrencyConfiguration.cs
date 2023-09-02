using Alazani.Domain.Entities;
using Alazani.Infrastructure.Repository.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alazani.Infrastructure.Repository.Configurations;

public class CurrencyConfiguration : BaseEntityConfiguration<Currency, int>
{
    public override void ConfigureEntity(EntityTypeBuilder<Currency> builder)
    {
        builder.Property(x => x.Name).HasColumnType("varchar(20)").HasMaxLength(20).IsRequired();
        builder.Property(x => x.Rate).HasColumnType("numeric").IsRequired();
        
    }
}
