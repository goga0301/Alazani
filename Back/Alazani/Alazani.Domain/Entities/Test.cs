using Alazani.Domain.Entities.Base;

namespace Alazani.Domain.Entities
{
    public class Test : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
