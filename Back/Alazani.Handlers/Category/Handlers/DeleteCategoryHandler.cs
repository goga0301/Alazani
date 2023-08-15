namespace Alazani.Handlers.Category.Handlers;

public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryCommand, IApiResponse<bool>>
{
    public Task<IApiResponse<bool>> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
