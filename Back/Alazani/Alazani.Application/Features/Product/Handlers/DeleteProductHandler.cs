using Alazani.Application.Features.Product.Commands;

namespace Alazani.Application.Features.Product.Handlers;

public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, IApiResponse<bool>>
{
    public Task<IApiResponse<bool>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
