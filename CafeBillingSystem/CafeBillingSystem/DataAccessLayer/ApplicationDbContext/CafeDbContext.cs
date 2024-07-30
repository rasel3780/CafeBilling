using CafeBillingSystem.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBillingSystem.DataAccessLayer.ApplicationDbContext
{
    
    public class CafeDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public CafeDbContext():base("CafeDbConnection")
        {
            Database.SetInitializer(new CafeDbInitializer());
        }
    }

    public class CafeDbInitializer : CreateDatabaseIfNotExists<CafeDbContext>
    {
        protected override void Seed(CafeDbContext context)
        {
            // Add admin user
            context.Users.Add(new User
            {
                Username = "admin",
                Password = "123456", 
                Role = Role.Admin
            });

            base.Seed(context);
        }
    }
}
