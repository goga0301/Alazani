using Alazani.Domain.Entities;
using Alazani.Domain.Entities.Enums;
using Alazani.Domain.Models.Domain;

namespace Alazani.Domain.Models.Mappers;

public static class CategoryMapper
{
    public static CategoryModel ToModel(this Category entity)
    {
        return new CategoryModel(entity.Id,
                                 entity.Name,       
                                 entity.Description,       
                                 entity.OrganizationId,       
                                 entity.Products?.Select(x => x.ToModel()).ToList(),       
                                 entity.RecordStatus,       
                                 entity.CreateDate,       
                                 entity.CreateUserId);       
    }

    public static Category ToEntity(this CreateCategoryModel model)
    {
        return new Category
        {
            Name = model.Name,
            Description = model.Description,
            OrganizationId = model.OrganizationId,
            RecordStatus = RecordStatusEnum.Active,
            CreateDate = DateTimeOffset.Now,
            CreateUserId = "Test"
        };
    }

    public static Category ToEntity(this UpdateCategoryModel model, Category category)
    {

        category.Name = model.Name;
        category.Description = model.Description;
        category.OrganizationId = model.OrganizationId;

        return category;
    }

}
