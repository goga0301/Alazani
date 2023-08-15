using Alazani.Application.Features.Organization.Commands;

namespace Alazani.Application.Features.Organization.Handlers;

public class UpdateOrganizationHandler : IRequestHandler<UpdateOrganizationCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(UpdateOrganizationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
