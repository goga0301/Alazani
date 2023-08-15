using Alazani.Application.Features.Organization.Queries;

namespace Alazani.Application.Features.Organization.Handlers;

public class GetOrganizationsHandler : IRequestHandler<GetOrganizationsQuery, IApiResponse<IEnumerable<OrganizationModel>>>
{
    public async Task<IApiResponse<IEnumerable<OrganizationModel>>> Handle(GetOrganizationsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
