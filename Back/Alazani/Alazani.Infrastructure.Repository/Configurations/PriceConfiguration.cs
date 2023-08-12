using Alazani.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Infrastructure.Repository.Configurations.Base;

namespace Alazani.Infrastructure.Repository.Configurations
{
    public class PriceConfiguration : BaseEntityConfiguration<Price, int>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Price> builder)
        {
            builder.HasOne<Product>().WithMany(x => x.Prices).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Currency).WithMany().HasForeignKey(x => x.CurrencyId);
        }
    }
}
