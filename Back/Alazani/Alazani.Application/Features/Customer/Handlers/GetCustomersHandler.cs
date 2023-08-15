using Alazani.Application.Features.Customer.Queries;

namespace Alazani.Application.Features.Customer.Handlers;

public class GetCustomersHandler : IRequestHandler<GetCustomersQuery, IApiResponse<IEnumerable<CustomerModel>>>
{
    public async Task<IApiResponse<IEnumerable<CustomerModel>>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
