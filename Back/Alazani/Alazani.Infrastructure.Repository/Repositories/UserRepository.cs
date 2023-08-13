using Alazani.Domain.Entities;
using Alazani.Domain.Repository;
using Alazani.Infrastructure.Repository.DbContexts;
using Alazani.Infrastructure.Repository.Repositories.Base;

namespace Alazani.Infrastructure.Repository.Repositories
{
    public class UserRepository : GenericRepository<AlazaniDbContext, User, int>, IUserRepository
    {
        public UserRepository(AlazaniDbContext context) : base(context)
        {
        }
    }
}
