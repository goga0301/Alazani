using Alazani.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Infrastructure.Repository.Configurations.Base;

namespace Alazani.Infrastructure.Repository.Configurations
{
    public class CurrencyConfiguration : BaseEntityConfiguration<Currency, int>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Currency> builder)
        {
            
        }
    }
}
