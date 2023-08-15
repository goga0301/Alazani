﻿namespace Alazani.Handlers.Customer.Commands;

public class CreateCustomerCommand : IRequest<IApiResponse<int>>
{
    public CreateCustomerModel Model { get; set; }

    public CreateCustomerCommand(CreateCustomerModel model)
    {
        Model = model;
    }
}
