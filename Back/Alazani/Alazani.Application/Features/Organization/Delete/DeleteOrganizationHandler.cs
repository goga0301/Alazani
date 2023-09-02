namespace Alazani.Application.Features.Organization.Delete;

public class DeleteOrganizationHandler : IRequestHandler<DeleteOrganizationCommand, IApiResponse<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IOrganizationRepository _organizationRepository;

    public DeleteOrganizationHandler(IUnitOfWork unitOfWork, IOrganizationRepository organizationRepository)
    {
        _unitOfWork = unitOfWork;
        _organizationRepository = organizationRepository;
    }

    public async Task<IApiResponse<bool>> Handle(DeleteOrganizationCommand request, CancellationToken cancellationToken)
    {
        var organization = await _organizationRepository.GetSingleAsync(x => x.Id == request.Id);
        if (organization == null)
        {
            throw new OrganizationNotFoundException($"Organization by ID: {request.Id} not found");
        }
        _organizationRepository.SoftDelete(organization);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return ApiResponse<bool>.Success(true, "Organization Deleted Succesfully");
    }
}
