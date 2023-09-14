namespace Alazani.Application.Features.Category.Delete;

public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryCommand, IApiResponse<bool>>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteCategoryHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    {
        _categoryRepository = categoryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IApiResponse<bool>> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetSingleAsync(x => x.Id == request.Id);
        if (category == null)
        {
            throw new Exception($"Category by ID:{request.Id} Not Found");
        }

        _categoryRepository.SoftDelete(category);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return ApiResponse<bool>.Success(true, "Category Deleted Successfully");
    }
}
