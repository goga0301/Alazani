namespace Alazani.Application.Features.Category.Delete;

public class DeleteCategoryCommand : IRequest<IApiResponse<bool>>
{
    public int Id { get; set; }

    public DeleteCategoryCommand(int id)
    {
        Id = id;
    }
}
