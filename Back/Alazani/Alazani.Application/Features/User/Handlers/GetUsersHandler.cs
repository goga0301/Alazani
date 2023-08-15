using Alazani.Application.Features.User.Queries;

namespace Alazani.Application.Features.User.Handlers;

public class GetUsersHandler : IRequestHandler<GetUsersQuery, IApiResponse<IEnumerable<UserModel>>>
{
    public async Task<IApiResponse<IEnumerable<UserModel>>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}