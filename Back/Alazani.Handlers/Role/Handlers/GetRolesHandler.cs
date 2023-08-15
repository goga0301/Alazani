namespace Alazani.Handlers.Role.Handlers;

public class GetRolesHandler : IRequestHandler<GetRolesQuery, IApiResponse<IEnumerable<RoleModel>>>
{
    public async Task<IApiResponse<IEnumerable<RoleModel>>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
