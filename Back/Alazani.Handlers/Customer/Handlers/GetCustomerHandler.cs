namespace Alazani.Handlers.Customer.Handlers;

public class GetCustomerHandler : IRequestHandler<GetCustomerQuery, IApiResponse<CustomerModel>>
{
    public async Task<IApiResponse<CustomerModel>> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
