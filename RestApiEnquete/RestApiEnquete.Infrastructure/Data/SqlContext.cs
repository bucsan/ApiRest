using Microsoft.EntityFrameworkCore;
using RestApiEnquete.Domain.Entitys;
using System;
using System.Linq;

namespace RestApiEnquete.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Poll> Polls { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Vote> Votes { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DateRegistration") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DateRegistration").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DateRegistration").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}