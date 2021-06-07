using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TruckRESTAPI.Domain.Entitys;

namespace TruckRESTAPI.Infrastructure.Data
{
    public class SqlContext: DbContext
    {

        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> options): base(options)
        {

        }

        public DbSet<Truck> Trucks { get; set; }

        public override int SaveChanges()
        {

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DateAdded") != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("DateAdded").CurrentValue = DateTime.Now;
                }
                if(entry.State == EntityState.Modified)
                {
                    entry.Property("DataAdded").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

    }
}
