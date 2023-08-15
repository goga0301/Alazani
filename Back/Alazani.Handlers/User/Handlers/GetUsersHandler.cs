namespace Alazani.Handlers.User.Handlers;

public class GetUsersHandler : IRequestHandler<GetUsersQuery, IApiResponse<IEnumerable<UserModel>>>
{
    public async Task<IApiResponse<IEnumerable<UserModel>>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}