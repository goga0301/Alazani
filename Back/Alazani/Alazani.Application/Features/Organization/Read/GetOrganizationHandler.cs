namespace Alazani.Application.Features.Organization.Read;

public class GetOrganizationHandler : IRequestHandler<GetOrganizationQuery, IApiResponse<OrganizationModel>>
{
    public async Task<IApiResponse<OrganizationModel>> Handle(GetOrganizationQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
