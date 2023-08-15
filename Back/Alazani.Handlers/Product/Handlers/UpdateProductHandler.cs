namespace Alazani.Handlers.Product.Handlers;

public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}