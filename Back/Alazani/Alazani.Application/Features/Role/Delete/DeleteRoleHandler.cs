using Alazani.Domain.Repository;

namespace Alazani.Application.Features.Role.Delete;

public class DeleteRoleHandler : IRequestHandler<DeleteRoleCommand, IApiResponse<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRoleRepository _roleRepository;

    public DeleteRoleHandler(IUnitOfWork unitOfWork, IRoleRepository roleRepository)
    {
        _unitOfWork = unitOfWork;
        _roleRepository = roleRepository;
    }

    public async Task<IApiResponse<bool>> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetSingleAsync(x => x.Id == request.Id);
        if (role == null)
        {
            throw new RoleNotFoundException($"Role by ID: {request.Id} not found");
        }
        _roleRepository.SoftDelete(role);
        await _unitOfWork.SaveChangesAsync();

        return ApiResponse<bool>.Success(true, "Role Deleted Succesfully");

    }
}
