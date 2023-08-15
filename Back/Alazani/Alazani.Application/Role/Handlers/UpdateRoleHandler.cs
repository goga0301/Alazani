namespace Alazani.Application.Role.Handlers;

public class UpdateRoleHandler : IRequestHandler<UpdateRoleCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
