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
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        public CafeDbContext():base("CafeDbConnection")
        {
            Database.SetInitializer(new CafeDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
               .HasRequired(od => od.Order)
               .WithMany(o => o.Items)
               .HasForeignKey(od => od.OrderId);

            modelBuilder.Entity<OrderDetail>()
                        .HasRequired(od => od.Item)
                        .WithMany()
                        .HasForeignKey(od => od.ItemId);

            base.OnModelCreating(modelBuilder);
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
