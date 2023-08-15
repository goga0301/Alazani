namespace Alazani.Application.Features.Category.Update;

public class UpdateCategoryCommand : IRequest<IApiResponse<bool>>
{
    public UpdateCategoryModel Model { get; set; }
    public UpdateCategoryCommand(UpdateCategoryModel model)
    {
        Model = model;
    }
}
