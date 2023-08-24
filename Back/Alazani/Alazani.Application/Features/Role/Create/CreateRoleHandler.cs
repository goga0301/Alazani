using Alazani.Domain.Models.Mappers;
using Alazani.Domain.Repository;

namespace Alazani.Application.Features.Role.Create;

public class CreateRoleHandler : IRequestHandler<CreateRoleCommand, IApiResponse<int>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRoleRepository _roleRepository;

    public CreateRoleHandler(IUnitOfWork unitOfWork, IRoleRepository roleRepository)
    {
        _unitOfWork = unitOfWork;
        _roleRepository = roleRepository;
    }
    public async Task<IApiResponse<int>> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        var entity = request.Model.ToEntity();

        await _roleRepository.CreateAsync(entity);
        await _unitOfWork.SaveChangesAsync();

        return ApiResponse<int>.Success(entity.Id, "Role Created Succesfully");
    
    }
}
