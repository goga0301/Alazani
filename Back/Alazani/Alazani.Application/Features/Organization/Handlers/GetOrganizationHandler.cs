using Alazani.Application.Features.Organization.Queries;

namespace Alazani.Application.Features.Organization.Handlers;

public class GetOrganizationHandler : IRequestHandler<GetOrganizationQuery, IApiResponse<OrganizationModel>>
{
    public async Task<IApiResponse<OrganizationModel>> Handle(GetOrganizationQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
