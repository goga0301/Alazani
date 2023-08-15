using Alazani.Application.Features.Customer.Commands;

namespace Alazani.Application.Features.Customer.Handlers;

public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
