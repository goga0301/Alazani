namespace Alazani.Application.Features.Organization.Update;

public class UpdateOrganizationCommand : IRequest<IApiResponse<bool>>
{
    public UpdateOrganizationModel Model { get; set; }
    public UpdateOrganizationCommand(UpdateOrganizationModel model)
    {
        Model = model;
    }
}
