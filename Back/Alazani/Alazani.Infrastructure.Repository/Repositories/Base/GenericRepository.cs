using Alazani.Domain.Entities.Base;
using Alazani.Domain.Entities.Enums;
using Alazani.Domain.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
using Alazani.Helpers;


namespace Alazani.Infrastructure.Repository.Repositories.Base;

public abstract class GenericRepository<TContext, TEntity> : IGenericRepository<TEntity>, IDisposable where TContext : DbContext where TEntity : class 
{
    protected readonly TContext _context;

    protected GenericRepository(TContext context)
    {
        _context = context;
    }

    public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includes)
    {
        return await GetQueryable(new[] { where }, includes).FirstOrDefaultAsync().ConfigureAwait(false);
    }

    public async Task<TEntity?> GetSingleAsync(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includes)
    {
        return await GetQueryable(new[] { where }, includes).SingleOrDefaultAsync().ConfigureAwait(false);
    }

    public async Task<List<TEntity>> GetRowsAsync(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includes)
    {
        return await GetQueryable(new[] { where }, includes).ToListAsync().ConfigureAwait(false);
    }

    public async Task<List<TEntity>> GetRowsAsync(int skip, int take, Expression<Func<TEntity, object>> orderByDesc, Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includes)
    {
        return await GetQueryable(new[] { where }, includes).OrderByDescending(orderByDesc).Skip(skip).Take(take).ToListAsync().ConfigureAwait(false);
    }

    public IQueryable<TEntity> GetRowsQueryable(Expression<Func<TEntity, bool>> where)
    {
        return GetQueryable(new[] { where });
    }

    public async Task<List<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includes)
    {
        return await GetQueryable(null, includes).ToListAsync().ConfigureAwait(false);
    }

    public async Task<List<TEntity>> GetAllAsync(int skip, int take, Expression<Func<TEntity, object>> orderByDesc, params Expression<Func<TEntity, object>>[] includes)
    {
        return await GetQueryable(null, includes).OrderByDescending(orderByDesc).Skip(skip).Take(take).ToListAsync().ConfigureAwait(false);
    }

    public IQueryable<TEntity> GetAllQueryable(params Expression<Func<TEntity, object>>[] includes)
    {
        return GetQueryable(null, includes);
    }

    public async Task<bool> AnyAsync(params Expression<Func<TEntity, bool>>[] where)
    {
        return await GetQueryable(where).AnyAsync().ConfigureAwait(false);
    }

    public Task CreateAsync(TEntity entity, bool trackGraph = false)
    {
        if (trackGraph)
        {
            _context.Set<TEntity>().Add(entity);
        }
        else
        {
            _context.Entry(entity).State = EntityState.Added;
        }
        return Task.CompletedTask;
    }

    public async Task CreateRange(IEnumerable<TEntity> entities, bool trackGraph = false) 
    {
        if (trackGraph)
        {
            _context.Set<TEntity>().AddRange(entities);
        }
        else
        {
            foreach (var entity in entities)
            {
                await CreateAsync(entity);
            }
        }
    }

    public void SoftDelete(TEntity entity, bool trackGraph = false)
    {
        if (entity is ISoftDeleteEntity softDeletable)
        {
            if (trackGraph)
            {
                _context.Set<TEntity>().Update(entity);
            }
            else
            {
                softDeletable.RecordStatus = RecordStatusEnum.Deleted;
            }
        }
        else
        {
            throw new Exception("Entity not configured for soft delete");
        }

        _context.Entry(entity).State = EntityState.Modified;
    }

    public void SoftDeleteRange(IEnumerable<TEntity> entities, bool trackGraph = false)
    {
        foreach (var item in entities)
        {
            SoftDelete(item, trackGraph);
        }
    }

    public void Update(TEntity entity, bool trackGraph = false)
    {
        if (trackGraph)
        {
            _context.Set<TEntity>().Update(entity);
        }
        else
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync().ConfigureAwait(false);
        DetacheTrackedEntities();
    }

    public void Dispose()
    {
        //_context?.Dispose();
        GC.SuppressFinalize(this);
    }

    private void DetacheTrackedEntities()
    {
        foreach (EntityEntry entityEntry in _context.ChangeTracker.Entries())
        {
            entityEntry.State = EntityState.Detached;
        }
    }

    private IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>>[]? wheres = null, Expression<Func<TEntity, object>>[]? includes = null)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>().AsNoTracking();

        if (wheres != null && wheres.Any())
        {
            Expression<Func<TEntity, bool>> expr = wheres[0];

            for (int i = 1; i < wheres.Length; i++)
            {
                var @where = wheres[0];
                expr = expr.And(@where);
            }

            query = query.Where(expr);
        }



        if (includes != null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        return query;
    }
}
