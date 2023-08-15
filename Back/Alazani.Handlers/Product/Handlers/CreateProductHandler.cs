namespace Alazani.Handlers.Product.Handlers;

public class CreateProductHandler : IRequestHandler<CreateProductCommand, IApiResponse<int>>
{
    public Task<IApiResponse<int>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}