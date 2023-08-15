namespace Alazani.Application.Features.User.Create;

public class CreateUserCommand : IRequest<IApiResponse<int>>
{
    public CreateUserModel Model { get; set; }

    public CreateUserCommand(CreateUserModel model)
    {
        Model = model;
    }
}
