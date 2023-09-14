namespace Alazani.Application.Features.Category.Read;

public class GetCategoryHandler : IRequestHandler<GetCategoryQuery, IApiResponse<CategoryModel>>
{
    private readonly ICategoryRepository _categoryRepository;

    public GetCategoryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<IApiResponse<CategoryModel>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetSingleAsync(x => x.Id == request.Id);
        if(category == null)
        {
            throw new Exception($"Category by ID:{request.Id} Not Found");
        }

        return ApiResponse<CategoryModel>.Success(category.ToModel());

    }
}

