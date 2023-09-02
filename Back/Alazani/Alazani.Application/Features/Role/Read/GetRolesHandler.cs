namespace Alazani.Application.Features.Role.Read;

public class GetRolesHandler : IRequestHandler<GetRolesQuery, IApiResponse<IEnumerable<RoleModel>>>
{
    private readonly IRoleRepository _roleRepository;

    public GetRolesHandler(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public async Task<IApiResponse<IEnumerable<RoleModel>>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
    {
        var roles = await _roleRepository.GetAllAsync();
        var models = roles.Select(x => x.ToModel());
        return ApiResponse<IEnumerable<RoleModel>>.Success(models, "Roles Retrieved Succesfully");

    }
}
