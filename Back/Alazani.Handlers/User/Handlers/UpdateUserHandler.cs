﻿namespace Alazani.Handlers.User.Handlers;

public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}