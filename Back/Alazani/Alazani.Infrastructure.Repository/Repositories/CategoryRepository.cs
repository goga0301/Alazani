using Alazani.Domain.Entities;
using Alazani.Domain.Repository;
using Alazani.Infrastructure.Repository.DbContexts;
using Alazani.Infrastructure.Repository.Repositories.Base;

namespace Alazani.Infrastructure.Repository.Repositories;

public class CategoryRepository : GenericRepository<AlazaniDbContext, Category>, ICategoryRepository
{
    public CategoryRepository(AlazaniDbContext context) : base(context)
    {
    }
}
