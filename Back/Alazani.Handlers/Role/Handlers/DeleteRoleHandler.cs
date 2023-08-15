namespace Alazani.Handlers.Role.Handlers;

public class DeleteRoleHandler : IRequestHandler<DeleteRoleCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
