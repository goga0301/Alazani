using Alazani.Domain.Entities.Enums;

namespace Alazani.Domain.Models.Domain
{
    public record CategoryModel(int Id,
                                string Name,
                                string Description,
                                int OrganizationId,
                                List<ProductModel>? Products,
                                RecordStatusEnum RecordStatus,
                                DateTimeOffset CreateDate,
                                string CreatorUserId);

    public record CreateCategoryModel(string Name, string Description, int OrganizationId);
    public record UpdateCategoryModel(int Id, string Name, string Description, int OrganizationId);
    public record DeleteCategoryModel(int Id);
}
