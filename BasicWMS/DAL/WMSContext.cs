using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BasicWMS.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BasicWMS.DAL
{
    public class WmsContext : DbContext
    {

        public DbSet<Product> Products { get; set; } 
        public DbSet<Order> Order { get; set; } 
        public DbSet<Purchase> Purchases { get; set; } 
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}