namespace Alazani.Application.Features.Category.Create;

public class CreateCategoryCommand : IRequest<IApiResponse<int>>
{
    public CreateCategoryModel Model { get; set; }

    public CreateCategoryCommand(CreateCategoryModel model)
    {
        Model = model;
    }
}


