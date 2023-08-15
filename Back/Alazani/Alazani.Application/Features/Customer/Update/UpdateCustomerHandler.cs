namespace Alazani.Application.Features.Customer.Update;

public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
