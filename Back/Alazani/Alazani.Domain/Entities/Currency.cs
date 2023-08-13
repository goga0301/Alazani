using Alazani.Domain.Entities.Base;

namespace Alazani.Domain.Entities;

public class Currency : BaseEntity<int>
{
    public string Name { get; set; }
    public decimal Rate { get; set; }

}
