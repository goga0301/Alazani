using Alazani.Domain.Entities;
using Alazani.Infrastructure.Repository.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Alazani.Infrastructure.Repository.DbContexts;

public class AlazaniDbContext : DbContext
{
    public DbSet<Organization> Organizations { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Currency> Currencies { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public AlazaniDbContext(DbContextOptions<AlazaniDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("AlazaniDb");
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrganizationConfiguration).Assembly);
        modelBuilder.Model.SetMaxIdentifierLength(30);

        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            entity.SetTableName(entity.DisplayName());
        }

        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }

        base.OnModelCreating(modelBuilder);
    }
}
