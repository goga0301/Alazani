using Alazani.Application.Features.Category.Commands;

namespace Alazani.Application.Features.Category.Handlers;

public class UpdateCategoryHandler : IRequestHandler<UpdateCategoryCommand, IApiResponse<bool>>
{
    public Task<IApiResponse<bool>> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
