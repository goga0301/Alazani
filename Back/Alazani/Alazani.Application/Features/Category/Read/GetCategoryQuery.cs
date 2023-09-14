namespace Alazani.Application.Features.Category.Read;

public class GetCategoryQuery : IRequest<IApiResponse<CategoryModel>>
{
    public int Id { get; set; }

    public GetCategoryQuery(int id)
    {
        Id = id;
    }
}
