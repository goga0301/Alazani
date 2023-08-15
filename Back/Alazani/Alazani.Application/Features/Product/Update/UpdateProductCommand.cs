namespace Alazani.Application.Features.Product.Update;

public class UpdateProductCommand : IRequest<IApiResponse<bool>>
{
    public UpdateProductModel Model { get; set; }
    public UpdateProductCommand(UpdateProductModel model)
    {
        Model = model;
    }
}
