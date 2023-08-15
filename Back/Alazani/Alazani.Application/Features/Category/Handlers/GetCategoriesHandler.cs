using Alazani.Application.Features.Category.Queries;

namespace Alazani.Application.Features.Category.Handlers;

public class GetCategoriesHandler : IRequestHandler<GetCategoriesQuery, IApiResponse<IEnumerable<CategoryModel>>>
{
    public Task<IApiResponse<IEnumerable<CategoryModel>>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
