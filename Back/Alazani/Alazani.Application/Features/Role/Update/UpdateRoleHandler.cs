namespace Alazani.Application.Features.Role.Update;

public class UpdateRoleHandler : IRequestHandler<UpdateRoleCommand, IApiResponse<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRoleRepository _roleRepository;

    public UpdateRoleHandler(IUnitOfWork unitOfWork, IRoleRepository roleRepository)
    {
        _unitOfWork = unitOfWork;
        _roleRepository = roleRepository;
    }

    public async Task<IApiResponse<bool>> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetSingleAsync(x => x.Id == request.Model.Id);
        if (role == null)
        {
            throw new RoleNotFoundException($"Role by ID: {request.Model.Id} not found");
        }
        request.Model.ToEntity(role);

        _roleRepository.Update(role);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return ApiResponse<bool>.Success(true, "Role Updated Succesfully");
    }
}
