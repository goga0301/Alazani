namespace Alazani.Application.Features.Product.Update;

public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}