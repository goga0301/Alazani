namespace Alazani.Handlers.Customer.Commands;

public class UpdateCustomerCommand : IRequest<IApiResponse<bool>>
{
    public UpdateCustomerModel Model { get; set; }
    public UpdateCustomerCommand(UpdateCustomerModel model)
    {
        Model = model;
    }
}
