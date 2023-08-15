namespace Alazani.Application.Features.User.Handlers;

public class GetUserHandler : IRequestHandler<GetUserQuery, IApiResponse<UserModel>>
{
    public async Task<IApiResponse<UserModel>> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}