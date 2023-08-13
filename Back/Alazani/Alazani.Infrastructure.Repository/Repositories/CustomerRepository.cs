using Alazani.Domain.Entities;
using Alazani.Domain.Repository;
using Alazani.Infrastructure.Repository.DbContexts;
using Alazani.Infrastructure.Repository.Repositories.Base;

namespace Alazani.Infrastructure.Repository.Repositories
{
    public class CustomerRepository : GenericRepository<AlazaniDbContext, Customer, int>, ICustomerRepository
    {
        public CustomerRepository(AlazaniDbContext context) : base(context)
        {
        }
    }
}
