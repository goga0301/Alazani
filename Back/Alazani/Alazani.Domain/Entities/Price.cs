using Alazani.Domain.Entities.Base;

namespace Alazani.Domain.Entities;

public class Price : BaseEntity<int>
{
    public int ProductId { get; set; }
    public int CurrencyId { get; set; }

    public virtual Currency Currency { get; set; }

}
