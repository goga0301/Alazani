namespace Alazani.Application.Features.Role.Create;

public class CreateRoleHandler : IRequestHandler<CreateRoleCommand, IApiResponse<int>>
{
    public async Task<IApiResponse<int>> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
