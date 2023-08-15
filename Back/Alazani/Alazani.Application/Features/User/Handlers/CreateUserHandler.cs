using Alazani.Application.Features.User.Commands;

namespace Alazani.Application.Features.User.Handlers;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, IApiResponse<int>>
{
    public async Task<IApiResponse<int>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}