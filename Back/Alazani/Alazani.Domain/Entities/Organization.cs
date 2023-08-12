using Alazani.Domain.Entities.Base;

namespace Alazani.Domain.Entities
{
    public class Organization : BaseEntity<int>
    {
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
        public virtual List<Category> Categories { get; set; }
        public virtual List<Role> Roles { get; set; }
        public virtual List<User> Users { get; set; }


    }
}
