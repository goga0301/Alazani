using Alazani.Domain.Entities;
using Alazani.Domain.Repository;
using Alazani.Infrastructure.Repository.DbContexts;
using Alazani.Infrastructure.Repository.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Alazani.Infrastructure.Repository.Repositories;

public class OrganizationRepository : GenericRepository<AlazaniDbContext, Organization>, IOrganizationRepository
{
    public OrganizationRepository(AlazaniDbContext context) : base(context)
    {
    }

    public async Task<bool> IsNameUnique(string name)
    {
        return !(await _context.Organizations.AnyAsync(x => x.Name == name));
    }
}
