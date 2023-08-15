namespace Alazani.Application.Features.Product.Read;

public class GetProductHandler : IRequestHandler<GetProductQuery, IApiResponse<ProductModel>>
{
    public async Task<IApiResponse<ProductModel>> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}