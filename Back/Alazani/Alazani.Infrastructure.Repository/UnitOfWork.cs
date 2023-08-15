using Alazani.Domain.Repository;
using Alazani.Infrastructure.Repository.DbContexts;
namespace Alazani.Infrastructure.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly AlazaniDbContext _context;
    public UnitOfWork(AlazaniDbContext context)
    {
        _context = context;
    }
    public Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }
}
