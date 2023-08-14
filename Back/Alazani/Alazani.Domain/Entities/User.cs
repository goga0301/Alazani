using Alazani.Domain.Entities.Base;

namespace Alazani.Domain.Entities;

public class User : BaseEntity<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string PhoneNumber { get; set; }
    public string PrivateNumber { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Status { get; set; }
    public int RoleId { get; set; } 
    public int OrganizationId { get; set; }

    public virtual Role? Role { get; set; }
}
