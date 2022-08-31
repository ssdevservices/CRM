using CRM.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM.Infrastructure.Context
{
    public class CRMDbContext : DbContext
    {
        public CRMDbContext(DbContextOptions<CRMDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Domain.Models.File> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Invoices)
                .WithOne();

            modelBuilder.Entity<Invoice>()
                .HasOne<Domain.Models.File>();
        }
    }
}
