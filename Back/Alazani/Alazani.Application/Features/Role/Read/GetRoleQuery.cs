namespace Alazani.Application.Features.Role.Read;

public class GetRoleQuery : IRequest<IApiResponse<RoleModel>>
{
    public int Id { get; set; }
    public GetRoleQuery(int id)
    {
        Id = id;
    }
}
