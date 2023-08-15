namespace Alazani.Application.Features.Product.Create;

public class CreateProductCommand : IRequest<IApiResponse<int>>
{
    public CreateProductModel Model { get; set; }

    public CreateProductCommand(CreateProductModel model)
    {
        Model = model;
    }
}