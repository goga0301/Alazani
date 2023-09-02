using Alazani.Domain.Entities;
using Alazani.Domain.Entities.Enums;
using Alazani.Domain.Models.Domain;

namespace Alazani.Domain.Models.Mappers;

public static class OrganizationMapper
{
    public static OrganizationModel ToModel(this Organization entity)
    {
        return new OrganizationModel(entity.Id,
                                     entity.Name,               
                                     entity.Description,               
                                     entity.Address,               
                                     entity.Products.Select(x => x.ToModel()).ToList(),               
                                     entity.Categories.Select(x => x.ToModel()).ToList(),               
                                     entity.Roles.Select(x => x.ToModel()).ToList(),               
                                     entity.Users.Select(x => x.ToModel()).ToList(),               
                                     entity.RecordStatus,               
                                     entity.CreateDate,               
                                     entity.CreateUserId);               
    }

    public static Organization ToEntity(this CreateOrganizationModel model)
    {
        return new Organization
        {
            Name = model.Name,
            Description = model.Description,
            Address = model.Address,
            RecordStatus = RecordStatusEnum.Active,
            CreateDate = DateTime.UtcNow,
            CreateUserId = "Test"
        };
    }

    public static Organization ToEntity(this UpdateOrganizationModel model, Organization organization)
    {

        organization.Name = model.Name;
        organization.Description = model.Description;
        organization.Address = model.Address;

        return organization;
    }

}
