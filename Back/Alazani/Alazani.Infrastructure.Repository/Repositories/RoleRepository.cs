using Alazani.Domain.Entities;
using Alazani.Domain.Repository;
using Alazani.Infrastructure.Repository.DbContexts;
using Alazani.Infrastructure.Repository.Repositories.Base;

namespace Alazani.Infrastructure.Repository.Repositories;

public class RoleRepository : GenericRepository<AlazaniDbContext, Role>, IRoleRepository
{
    public RoleRepository(AlazaniDbContext context) : base(context)
    {
    }
}
