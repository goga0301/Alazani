namespace Alazani.Application.Features.Organization.Read;

public class GetOrganizationsHandler : IRequestHandler<GetOrganizationsQuery, IApiResponse<IEnumerable<OrganizationModel>>>
{
    private readonly IOrganizationRepository _organizationRepository;
    
    public GetOrganizationsHandler(IOrganizationRepository organizationRepository)
    {
        _organizationRepository = organizationRepository;
    }
    public async Task<IApiResponse<IEnumerable<OrganizationModel>>> Handle(GetOrganizationsQuery request, CancellationToken cancellationToken)
    {
        var organizations = await _organizationRepository.GetAllAsync();
        var models = organizations.Select(x => x.ToModel());
        return ApiResponse<IEnumerable<OrganizationModel>>.Success(models, "Organizations Retrieved Succesfully");
    
    }
}
