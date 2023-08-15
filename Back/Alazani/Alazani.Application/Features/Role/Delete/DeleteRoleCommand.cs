namespace Alazani.Application.Features.Role.Delete;

public class DeleteRoleCommand : IRequest<IApiResponse<bool>>
{
    public int Id { get; set; }

    public DeleteRoleCommand(int id)
    {
        Id = id;
    }
}
