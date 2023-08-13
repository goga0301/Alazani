using Alazani.Domain.Entities.Base;

namespace Alazani.Domain.Entities;

public class User : BaseEntity<int>
{
    public int RoleId { get; set; } 
    public int OrganizationId { get; set; }
}
