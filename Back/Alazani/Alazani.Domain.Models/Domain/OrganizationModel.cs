using Alazani.Domain.Entities.Enums;

namespace Alazani.Domain.Models.Domain;

public record OrganizationModel(int Id,
                         string Name,
                         string Description,
                         string Address,
                         List<ProductModel>? Products,
                         List<CategoryModel>? Categories,
                         List<RoleModel>? Roles,
                         List<UserModel>? Users,
                         RecordStatusEnum RecordStatus,
                         DateTimeOffset CreateDate,
                         string CreatorUserId);
