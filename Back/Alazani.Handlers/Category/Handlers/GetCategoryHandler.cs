namespace Alazani.Handlers.Category.Handlers;

public class GetCategoryHandler : IRequestHandler<GetCategoryQuery, IApiResponse<CategoryModel>>
{
    public Task<IApiResponse<CategoryModel>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

