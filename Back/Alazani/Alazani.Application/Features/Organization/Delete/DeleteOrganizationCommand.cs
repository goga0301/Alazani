namespace Alazani.Application.Features.Organization.Delete;

public class DeleteOrganizationCommand : IRequest<IApiResponse<bool>>
{
    public int Id { get; set; }
    public DeleteOrganizationCommand(int id)
    {
        Id = id;
    }
}
