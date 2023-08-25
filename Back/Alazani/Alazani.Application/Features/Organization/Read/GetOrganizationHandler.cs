using Alazani.Domain.Models.Mappers;
using Alazani.Domain.Repository;
using FluentValidation;

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
        var organization = (await _organizationRepository.GetSingleAsync(x => x.Id == request.Id))!;

        var model = organization.ToModel();

        return ApiResponse<OrganizationModel>.Success(model, "Organization Retrieved Succesfully");
    }
}