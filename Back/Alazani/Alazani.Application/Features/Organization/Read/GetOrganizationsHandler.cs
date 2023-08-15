namespace Alazani.Application.Features.Organization.Read;

public class GetOrganizationsHandler : IRequestHandler<GetOrganizationsQuery, IApiResponse<IEnumerable<OrganizationModel>>>
{
    public async Task<IApiResponse<IEnumerable<OrganizationModel>>> Handle(GetOrganizationsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
