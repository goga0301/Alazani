namespace Alazani.Handlers.Customer.Commands;

public class DeleteCustomerCommand : IRequest<IApiResponse<bool>>
{
    public int Id { get; set; }
    public DeleteCustomerCommand(int id)
    {
        Id = id;
    }
}