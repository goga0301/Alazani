namespace Alazani.Application.Features.Category.Update;

public class UpdateCategoryHandler : IRequestHandler<UpdateCategoryCommand, IApiResponse<bool>>
{
    public Task<IApiResponse<bool>> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
