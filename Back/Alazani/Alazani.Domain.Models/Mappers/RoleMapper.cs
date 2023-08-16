using Alazani.Domain.Entities;
using Alazani.Domain.Entities.Enums;
using Alazani.Domain.Models.Domain;

namespace Alazani.Domain.Models.Mappers;

public static class RoleMapper
{
    public static RoleModel ToModel(this Role entity)
    {
        return new RoleModel(entity.Id,
                             entity.Name,   
                             entity.Description,   
                             entity.OrganizationId,   
                             entity.RecordStatus,   
                             entity.CreateDate,                  
                             entity.CreateUserId);                  
    }

    public static Role ToEntity(this CreateRoleModel model)
    {
        return new Role
        {
            Name = model.Name,
            Description = model.Description,
            OrganizationId = model.OrganizationId,
            RecordStatus = RecordStatusEnum.Active,
            CreateDate = DateTime.UtcNow,
            CreateUserId = "Test"
        };
    }

    public static Role ToEntity(this UpdateRoleModel model, Role role)
    {

        role.Name = model.Name;
        role.Description = model.Description;
        role.OrganizationId = model.OrganizationId;

        return role;
    }
}
