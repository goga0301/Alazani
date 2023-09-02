namespace Alazani.Application.Features.Role.Read;

public class GetRoleHandler : IRequestHandler<GetRoleQuery, IApiResponse<RoleModel>>
{
    private readonly IRoleRepository _roleRepository;

    public GetRoleHandler(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public async Task<IApiResponse<RoleModel>> Handle(GetRoleQuery request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetSingleAsync(x => x.Id == request.Id);
        if (role == null)
        {
            throw new RoleNotFoundException($"Role by ID: {request.Id} not found");
        }
        var model = role.ToModel();
        return ApiResponse<RoleModel>.Success(model, "Role Retrieved Succesfully");
    }
}
