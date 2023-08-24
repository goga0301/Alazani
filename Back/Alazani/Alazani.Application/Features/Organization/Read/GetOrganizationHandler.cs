using Alazani.Domain.Models.Mappers;
using Alazani.Domain.Repository;

namespace Alazani.Application.Features.Organization.Read;

public class GetOrganizationHandler : IRequestHandler<GetOrganizationQuery, IApiResponse<OrganizationModel>>
{
    private readonly IOrganizationRepository _organizationRepository;

    public GetOrganizationHandler(IOrganizationRepository organizationRepository)
    {
        _organizationRepository = organizationRepository;
    }

    public async Task<IApiResponse<OrganizationModel>> Handle(GetOrganizationQuery request, CancellationToken cancellationToken)
    {
        var organization = await _organizationRepository.GetSingleAsync(x => x.Id == request.Id);
        if (organization == null)
        {
            throw new OrganizationNotFoundException($"Organization by ID: {request.Id} not found");
        }

        var model = organization.ToModel();

        return ApiResponse<OrganizationModel>.Success(model, "Organization Retrieved Succesfully");
    }
}
