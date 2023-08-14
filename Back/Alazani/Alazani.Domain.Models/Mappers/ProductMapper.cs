using Alazani.Domain.Entities;
using Alazani.Domain.Entities.Enums;
using Alazani.Domain.Models.Domain;

namespace Alazani.Domain.Models.Mappers;

public static class ProductMapper
{
    public static ProductModel ToModel(this Product entity)
    {
        return new ProductModel(entity.Id,
                                entity.Name,
                                entity.Description,
                                entity.Price,
                                entity.Stock,
                                entity.OrganizationId,
                                entity.CategoryId,
                                entity.Currency?.ToModel(),
                                entity.RecordStatus,
                                entity.CreateDate,
                                entity.CreateUserId);
    }

    public static Product ToEntity(this CreateProductModel model)
    {
        return new Product
        {
            Name = model.Name,
            Description = model.Description,
            Price = model.Price,
            Stock = model.Stock,
            OrganizationId = model.OrganizationId,
            CategoryId = model.CategoryId,
            CurrencyId = model.CurrencyId,
            RecordStatus = RecordStatusEnum.Active,
            CreateDate = DateTimeOffset.Now,
            CreateUserId = "Test"
        };
    }

    public static Product ToEntity(this UpdateProductModel model, Product product)
    {

        product.Name = model.Name;
        product.Description = model.Description;
        product.Price = model.Price;
        product.Stock = model.Stock;
        product.OrganizationId = model.OrganizationId;
        product.CategoryId = model.CategoryId;
        product.CurrencyId = model.CurrencyId;

        return product;
    }
}
