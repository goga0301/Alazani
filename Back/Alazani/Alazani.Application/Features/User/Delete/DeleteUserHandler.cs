namespace Alazani.Application.Features.User.Delete;

public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
