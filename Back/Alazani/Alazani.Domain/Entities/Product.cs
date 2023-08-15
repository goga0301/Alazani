using Alazani.Domain.Entities.Base;

namespace Alazani.Domain.Entities;

public class Product : BaseEntity<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public int OrganizationId { get; set; }
    public int CategoryId { get; set; }
    public int CurrencyId { get; set; }

    public virtual Currency? Currency { get; set; }
    public virtual Category? Category { get; set; }

}
