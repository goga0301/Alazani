using Alazani.Application.Features.Customer.Queries;

namespace Alazani.Application.Features.Customer.Handlers;

public class GetCustomerHandler : IRequestHandler<GetCustomerQuery, IApiResponse<CustomerModel>>
{
    public async Task<IApiResponse<CustomerModel>> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
