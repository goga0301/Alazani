namespace Alazani.Application.Features.Category.Update;

public class UpdateCategoryHandler : IRequestHandler<UpdateCategoryCommand, IApiResponse<bool>>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateCategoryHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    {
        _categoryRepository = categoryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IApiResponse<bool>> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetSingleAsync(x => x.Id == request.Model.Id);
    
        if (category == null)
        {
            throw new CategoryNotFoundException($"Category by ID: {request.Model.Id} not found");
        }

        var entity = request.Model.ToEntity(category);
        _categoryRepository.Update(entity);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return ApiResponse<bool>.Success(true, "Category Updated Succesfully");

    }
}
