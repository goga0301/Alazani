namespace Alazani.Application.User.Commands;

public class CreateUserCommand : IRequest<IApiResponse<int>>
{
    public CreateUserModel Model { get; set; }

    public CreateUserCommand(CreateUserModel model)
    {
        Model = model;
    }
}
