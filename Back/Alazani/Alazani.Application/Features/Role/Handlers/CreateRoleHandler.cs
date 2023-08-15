using Alazani.Application.Features.Role.Commands;

namespace Alazani.Application.Features.Role.Handlers;

public class CreateRoleHandler : IRequestHandler<CreateRoleCommand, IApiResponse<int>>
{
    public async Task<IApiResponse<int>> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
