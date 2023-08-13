using Alazani.Domain.Entities;
using Alazani.Domain.Repository;
using Alazani.Infrastructure.Repository.DbContexts;
using Alazani.Infrastructure.Repository.Repositories.Base;

namespace Alazani.Infrastructure.Repository.Repositories
{
    public class ProductRepository : GenericRepository<AlazaniDbContext, Product, int>, IProductRepository
    {
        public ProductRepository(AlazaniDbContext context) : base(context)
        {
        }
    }
}
