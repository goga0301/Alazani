using Alazani.Domain.Entities.Base;

namespace Alazani.Domain.Entities;

public class Product : BaseEntity<int>
{
    public int OrganizationId { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
    public virtual List<Price> Prices { get; set; }
}
