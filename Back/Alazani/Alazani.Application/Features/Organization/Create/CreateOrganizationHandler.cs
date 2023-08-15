namespace Alazani.Application.Features.Organization.Create;

public class CreateOrganizationHandler : IRequestHandler<CreateOrganizationCommand, IApiResponse<int>>
{
    public Task<IApiResponse<int>> Handle(CreateOrganizationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
