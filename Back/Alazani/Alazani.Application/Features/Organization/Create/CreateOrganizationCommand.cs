namespace Alazani.Application.Features.Organization.Create;

public class CreateOrganizationCommand : IRequest<IApiResponse<int>>
{
    public CreateOrganizationModel Model { get; set; }
    public CreateOrganizationCommand(CreateOrganizationModel model)
    {
        Model = model;
    }
}
