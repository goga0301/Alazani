using Alazani.Domain.Entities.Enums;

namespace Alazani.Domain.Models.Domain;


public record RoleModel(int Id,
                        string Name,
                        string Description,
                        int OrganizationId,
                        RecordStatusEnum RecordStatus,
                        DateTimeOffset CreateDate,
                        string CreatorUserId);
public record CreateRoleModel(string Name,
                              string Description,
                              int OrganizationId);
public record UpdateRoleModel(int Id,
                              string Name,
                              string Description,
                              int OrganizationId);
public record DeleteRoleModel(int Id);