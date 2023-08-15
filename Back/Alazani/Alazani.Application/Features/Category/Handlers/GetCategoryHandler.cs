using Alazani.Application.Features.Category.Queries;

namespace Alazani.Application.Features.Category.Handlers;

public class GetCategoryHandler : IRequestHandler<GetCategoryQuery, IApiResponse<CategoryModel>>
{
    public Task<IApiResponse<CategoryModel>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

