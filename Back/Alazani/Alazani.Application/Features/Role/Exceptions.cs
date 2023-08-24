namespace Alazani.Application.Features.Role;

public class RoleNotFoundException : Exception
{
    public RoleNotFoundException(string message) : base(message)
    {
    }
}