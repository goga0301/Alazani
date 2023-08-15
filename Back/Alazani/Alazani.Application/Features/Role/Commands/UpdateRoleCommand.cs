namespace Alazani.Application.Features.Role.Commands;

public class UpdateRoleCommand : IRequest<IApiResponse<bool>>
{
    public UpdateRoleModel Model { get; set; }
    public UpdateRoleCommand(UpdateRoleModel model)
    {
        Model = model;
    }
}