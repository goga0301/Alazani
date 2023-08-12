using Alazani.Domain.Entities.Base;

namespace Alazani.Domain.Entities
{
    public class Role : BaseEntity<int>
    {
        public int OrganizationId { get; set; }

        public virtual List<User> Users { get; set; }

    }
}
