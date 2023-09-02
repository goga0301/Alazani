using Microsoft.Extensions.Logging;

namespace Alazani.Application.Features.Organization.Create;

public class CreateOrganizationHandler : IRequestHandler<CreateOrganizationCommand, IApiResponse<int>>
{
    private readonly IOrganizationRepository _organizationRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<CreateOrganizationHandler> _logger;

    public CreateOrganizationHandler(IOrganizationRepository organizationRepository, IUnitOfWork unitOfWork, ILogger<CreateOrganizationHandler> logger)
    {
        _organizationRepository = organizationRepository;
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<IApiResponse<int>> Handle(CreateOrganizationCommand request, CancellationToken cancellationToken)
    {
        var entity = request.Model.ToEntity();  

        await _organizationRepository.CreateAsync(entity);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return ApiResponse<int>.Success(entity.Id, "Organization Created Successfully");
    }
}
