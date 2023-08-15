namespace Alazani.Application.Features.Organization.Handlers;

public class DeleteOrganizationHandler : IRequestHandler<DeleteOrganizationCommand, IApiResponse<bool>>
{
    public Task<IApiResponse<bool>> Handle(DeleteOrganizationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
