namespace Alazani.Application.Organization.Commands;

public class CreateOrganizationCommand : IRequest<IApiResponse<int>>
{
    public CreateOrganizationModel Model { get; set; }
    public CreateOrganizationCommand(CreateOrganizationModel model)
    {
        Model = model;
    }
}
