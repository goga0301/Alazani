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
                                DateTime CreateDate,
                                string CreatorUserId);

public record CreateOrganizationModel(string Name,
                                      string Description,  
                                      string Address);
public record UpdateOrganizationModel(int Id,
                                      string Name,
                                      string Description,
                                      string Address);
public record DeleteOrganizationModel(int Id);

