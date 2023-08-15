using Alazani.Application.Features.Product.Commands;

namespace Alazani.Application.Features.Product.Handlers;

public class CreateProductHandler : IRequestHandler<CreateProductCommand, IApiResponse<int>>
{
    public Task<IApiResponse<int>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}