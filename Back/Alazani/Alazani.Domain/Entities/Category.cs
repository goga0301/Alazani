using Alazani.Domain.Entities.Base;

namespace Alazani.Domain.Entities;

public class Category : BaseEntity<int>
{
    public int OrganizationId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual List<Product> Products { get; set; }
}
