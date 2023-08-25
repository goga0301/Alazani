using Alazani.Domain.Entities;
using Alazani.Domain.Repository.Base;

namespace Alazani.Domain.Repository;

public interface IOrganizationRepository : IGenericRepository<Organization>
{
    Task<bool> IsNameUnique(string name);
}
