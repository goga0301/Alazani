using Alazani.Domain.Entities.Base;

namespace Alazani.Domain.Entities
{
    public class Customer : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Password{ get; set; }
    }
}
