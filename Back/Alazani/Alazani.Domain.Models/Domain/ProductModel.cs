using Alazani.Domain.Entities.Enums;

namespace Alazani.Domain.Models.Domain
{
    public record ProductModel(int Id,
                             string Name,
                             string Description,
                             decimal Price,
                             int Stock,
                             int OrganizationId,
                             int CategotyId,
                             CurrencyModel Currency,
                             RecordStatusEnum RecordStatus,
                             DateTimeOffset CreateDate,
                             string CreatorUserId);
    public record CreateProductModel(string Name,
                                     string Description,
                                     decimal Price,
                                     int Stock,
                                     int OrganizationId,
                                     int CategotyId,
                                     int CurrencyId);

    public record UpdateProductModel(int Id,
                                     string Name,
                                     string Description,
                                     decimal Price,
                                     int Stock,
                                     int OrganizationId,
                                     int CategotyId,
                                     int CurrencyId);
    public record DeleteProductModel(int Id);
}