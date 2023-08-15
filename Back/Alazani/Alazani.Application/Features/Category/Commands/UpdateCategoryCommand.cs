namespace Alazani.Application.Features.Category.Commands;

public class UpdateCategoryCommand : IRequest<IApiResponse<bool>>
{
    public UpdateCategoryModel Model { get; set; }
    public UpdateCategoryCommand(UpdateCategoryModel model)
    {
        Model = model;
    }
}
