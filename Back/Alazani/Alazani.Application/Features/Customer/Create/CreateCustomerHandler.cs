﻿namespace Alazani.Application.Features.Customer.Create;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, IApiResponse<int>>
{
    public Task<IApiResponse<int>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
