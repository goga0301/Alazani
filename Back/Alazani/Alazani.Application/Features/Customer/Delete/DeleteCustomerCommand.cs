namespace Alazani.Application.Features.Customer.Delete;

public class DeleteCustomerCommand : IRequest<IApiResponse<bool>>
{
    public int Id { get; set; }
    public DeleteCustomerCommand(int id)
    {
        Id = id;
    }
}