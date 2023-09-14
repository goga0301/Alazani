namespace Alazani.Application.Features.Category.Read;

public class GetCategoriesHandler : IRequestHandler<GetCategoriesQuery, IApiResponse<IEnumerable<CategoryModel>>>
{
    private readonly ICategoryRepository _categoryRepository;

    public GetCategoriesHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<IApiResponse<IEnumerable<CategoryModel>>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        var categories = await _categoryRepository.GetAllAsync();

        return ApiResponse<IEnumerable<CategoryModel>>
            .Success(categories.Select(x => x.ToModel()));
    }
}
