using Alazani.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Infrastructure.Repository.Configurations.Base;

namespace Alazani.Infrastructure.Repository.Configurations;

public class CategoryConfiguration : BaseEntityConfiguration<Category, int>
{
    public override void ConfigureEntity(EntityTypeBuilder<Category> builder)
    {
    }
}
