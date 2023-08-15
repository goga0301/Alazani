namespace Alazani.Handlers.Organization.Handlers;

public class UpdateOrganizationHandler : IRequestHandler<UpdateOrganizationCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(UpdateOrganizationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
