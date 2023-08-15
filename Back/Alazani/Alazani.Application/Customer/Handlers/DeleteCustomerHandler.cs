namespace Alazani.Application.Customer.Handlers;

public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
