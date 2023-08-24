namespace Alazani.Application.Features.Organization;

public class OrganizationNotFoundException : Exception
{
    public OrganizationNotFoundException(string message) : base(message)
    {
    }
}