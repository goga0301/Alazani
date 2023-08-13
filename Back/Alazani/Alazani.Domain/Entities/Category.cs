using Alazani.Domain.Entities.Base;

namespace Alazani.Domain.Entities;

public class Category : BaseEntity<int>
{
    public int OrganizationId { get; set; }

    public virtual List<Product> Products { get; set; }
}
