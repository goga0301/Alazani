namespace Alazani.Application.Features.Organization.Handlers;

public class CreateOrganizationHandler : IRequestHandler<CreateOrganizationCommand, IApiResponse<int>>
{
    public Task<IApiResponse<int>> Handle(CreateOrganizationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
