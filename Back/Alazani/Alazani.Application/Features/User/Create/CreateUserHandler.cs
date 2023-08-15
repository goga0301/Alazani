namespace Alazani.Application.Features.User.Create;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, IApiResponse<int>>
{
    public async Task<IApiResponse<int>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}