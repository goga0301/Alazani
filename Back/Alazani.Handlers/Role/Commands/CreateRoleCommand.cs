namespace Alazani.Handlers.Role.Commands;

public class CreateRoleCommand : IRequest<IApiResponse<int>>
{
    public CreateRoleModel Model { get; set; }

    public CreateRoleCommand(CreateRoleModel model)
    {
        Model = model;
    }
}
