namespace Alazani.Handlers.Role.Handlers;

public class GetRoleHandler : IRequestHandler<GetRoleQuery, IApiResponse<RoleModel>>
{
    public async Task<IApiResponse<RoleModel>> Handle(GetRoleQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
