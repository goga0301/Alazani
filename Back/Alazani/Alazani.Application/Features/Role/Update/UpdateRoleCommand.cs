namespace Alazani.Application.Features.Role.Update;

public class UpdateRoleCommand : IRequest<IApiResponse<bool>>
{
    public UpdateRoleModel Model { get; set; }
    public UpdateRoleCommand(UpdateRoleModel model)
    {
        Model = model;
    }
}