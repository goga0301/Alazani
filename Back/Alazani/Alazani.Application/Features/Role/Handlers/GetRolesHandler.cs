using Alazani.Application.Features.Role.Queries;

namespace Alazani.Application.Features.Role.Handlers;

public class GetRolesHandler : IRequestHandler<GetRolesQuery, IApiResponse<IEnumerable<RoleModel>>>
{
    public async Task<IApiResponse<IEnumerable<RoleModel>>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
