using Alazani.Domain.Entities;
using Alazani.Domain.Repository;
using Alazani.Infrastructure.Repository.DbContexts;
using Alazani.Infrastructure.Repository.Repositories.Base;

namespace Alazani.Infrastructure.Repository.Repositories;

public class OrganizationRepository : GenericRepository<AlazaniDbContext, Organization, int>, IOrganizationRepository
{
    public OrganizationRepository(AlazaniDbContext context) : base(context)
    {
    }
}
