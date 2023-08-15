namespace Alazani.Application.Features.Organization.Commands;

public class UpdateOrganizationCommand : IRequest<IApiResponse<bool>>
{
    public UpdateOrganizationModel Model { get; set; }
    public UpdateOrganizationCommand(UpdateOrganizationModel model)
    {
        Model = model;
    }
}
