namespace Alazani.Handlers.Product.Commands;

public class CreateProductCommand : IRequest<IApiResponse<int>>
{
    public CreateProductModel Model { get; set; }

    public CreateProductCommand(CreateProductModel model)
    {
        Model = model;
    }
}