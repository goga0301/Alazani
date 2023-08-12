using Alazani.Domain.Entities;
using Alazani.Infrastructure.Repository.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Alazani.Infrastructure.Repository.DbContexts
{
    public class AlazaniDbContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }

        public AlazaniDbContext(DbContextOptions<AlazaniDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("AlazaniDb");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TestConfiguration).Assembly);
            modelBuilder.Model.SetMaxIdentifierLength(30);

            base.OnModelCreating(modelBuilder);
        }
    }
}
