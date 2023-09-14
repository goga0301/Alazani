using Microsoft.Extensions.Logging;
using NLog;

namespace Alazani.Application.Features.Category.Create;

public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, IApiResponse<int>>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateCategoryHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork )
    {
        _categoryRepository = categoryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IApiResponse<int>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var entity =  request.Model.ToEntity();

        await _categoryRepository.CreateAsync(entity);
        await _unitOfWork.SaveChangesAsync();

        return ApiResponse<int>.Success(entity.Id, "Category Created Successfully");
    }
}