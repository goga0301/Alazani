namespace Alazani.Application.Organization.Handlers;

public class GetOrganizationsHandler : IRequestHandler<GetOrganizationsQuery, IApiResponse<IEnumerable<OrganizationModel>>>
{
    public async Task<IApiResponse<IEnumerable<OrganizationModel>>> Handle(GetOrganizationsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
