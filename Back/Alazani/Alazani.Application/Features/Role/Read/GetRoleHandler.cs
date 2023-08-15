namespace Alazani.Application.Features.Role.Read;

public class GetRoleHandler : IRequestHandler<GetRoleQuery, IApiResponse<RoleModel>>
{
    public async Task<IApiResponse<RoleModel>> Handle(GetRoleQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
