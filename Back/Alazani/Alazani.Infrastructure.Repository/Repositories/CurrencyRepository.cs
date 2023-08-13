using Alazani.Domain.Entities;
using Alazani.Domain.Repository;
using Alazani.Infrastructure.Repository.DbContexts;
using Alazani.Infrastructure.Repository.Repositories.Base;

namespace Alazani.Infrastructure.Repository.Repositories
{
    public class CurrencyRepository : GenericRepository<AlazaniDbContext, Currency, int>, ICurrencyRepository
    {
        public CurrencyRepository(AlazaniDbContext context) : base(context)
        {
        }
    }
}
