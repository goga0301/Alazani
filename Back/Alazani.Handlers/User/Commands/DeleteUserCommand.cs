﻿namespace Alazani.Handlers.User.Commands;

public class DeleteUserCommand : IRequest<IApiResponse<bool>>
{
    public int Id { get; set; }
    public DeleteUserCommand(int id)
    {
        Id = id;
    }
}