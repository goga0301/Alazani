namespace Alazani.Handlers.Customer.Handlers;

public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
