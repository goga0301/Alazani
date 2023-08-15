namespace Alazani.Handlers.Product.Handlers;

public class GetProductsHandler : IRequestHandler<GetProductsQuery, IApiResponse<IEnumerable<ProductModel>>>
{
    public async Task<IApiResponse<IEnumerable<ProductModel>>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
