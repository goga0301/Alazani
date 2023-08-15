namespace Alazani.Application.Product.Commands;

public class CreateProductCommand : IRequest<IApiResponse<int>>
{
    public CreateProductModel Model { get; set; }

    public CreateProductCommand(CreateProductModel model)
    {
        Model = model;
    }
}