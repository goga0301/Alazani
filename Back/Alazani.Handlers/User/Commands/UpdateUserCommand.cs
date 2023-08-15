﻿namespace Alazani.Handlers.User.Commands;

public class UpdateUserCommand : IRequest<IApiResponse<bool>>
{
    public UpdateUserModel Model { get; set; }
    public UpdateUserCommand(UpdateUserModel model)
    {
        Model = model;
    }
}