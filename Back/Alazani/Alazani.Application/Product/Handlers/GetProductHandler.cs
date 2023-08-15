namespace Alazani.Application.Product.Handlers;

public class GetProductHandler : IRequestHandler<GetProductQuery, IApiResponse<ProductModel>>
{
    public async Task<IApiResponse<ProductModel>> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}