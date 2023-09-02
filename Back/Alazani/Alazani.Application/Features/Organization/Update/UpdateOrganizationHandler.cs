namespace Alazani.Application.Features.Organization.Update;

public class UpdateOrganizationHandler : IRequestHandler<UpdateOrganizationCommand, IApiResponse<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IOrganizationRepository _organizationRepository;

    public UpdateOrganizationHandler(IUnitOfWork unitOfWork, IOrganizationRepository organizationRepository)
    {
        _unitOfWork = unitOfWork;
        _organizationRepository = organizationRepository;
    }   

    public async Task<IApiResponse<bool>> Handle(UpdateOrganizationCommand request, CancellationToken cancellationToken)
    {
        var organization = await _organizationRepository.GetSingleAsync(x => x.Id == request.Model.Id);
        if (organization == null)
        {
            throw new OrganizationNotFoundException($"Organization by ID: {request.Model.Id} not found");
        }

        var entity = request.Model.ToEntity(organization);
        
        _organizationRepository.Update(entity);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return ApiResponse<bool>.Success(true, "Organization Updated Succesfully");
    }
}
