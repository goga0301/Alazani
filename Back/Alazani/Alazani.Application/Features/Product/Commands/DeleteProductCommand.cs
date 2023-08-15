namespace Alazani.Application.Features.Product.Commands;

public class DeleteProductCommand : IRequest<IApiResponse<bool>>
{
    public int Id { get; set; }
    public DeleteProductCommand(int id)
    {
        Id = id;
    }
}