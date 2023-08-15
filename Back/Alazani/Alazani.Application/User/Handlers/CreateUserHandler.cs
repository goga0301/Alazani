namespace Alazani.Application.User.Handlers;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, IApiResponse<int>>
{
    public async Task<IApiResponse<int>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}