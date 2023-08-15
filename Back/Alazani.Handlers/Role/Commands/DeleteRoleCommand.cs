namespace Alazani.Handlers.Role.Commands;

public class DeleteRoleCommand : IRequest<IApiResponse<bool>>
{
    public int Id { get; set; }

    public DeleteRoleCommand(int id)
    {
        Id = id;
    }
}
