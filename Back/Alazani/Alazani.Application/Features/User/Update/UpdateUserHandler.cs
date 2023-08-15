namespace Alazani.Application.Features.User.Update;

public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}