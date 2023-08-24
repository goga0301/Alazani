namespace Alazani.Application.Features.Organization.Read;

public class GetOrganizationQuery : IRequest<IApiResponse<OrganizationModel>>
{
    public int Id { get; set; }
    public GetOrganizationQuery(int id)
    {
        Id = id;
    }
}
