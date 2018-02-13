using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Data.Configurations;
using BasicWMS.Models;

namespace BasicWMS.Data
{
    public class BasicWmsContext : DbContext
    {
        public BasicWmsContext() : base("BasicWMS")
        {
            Database.SetInitializer<BasicWmsContext>(null);
        }

        #region Entity Sets
        public IDbSet<User> UserSet { get; set; } 
        public IDbSet<Role> RoleSet { get; set; } 
        public IDbSet<UserRole> UserRoleSet { get; set; } 
        public IDbSet<Product> ProductSet { get; set; } 
        public IDbSet<ProductType> ProductTypeSet { get; set; } 
        public IDbSet<Order> OrderSet { get; set; } 
        public IDbSet<Stock> StockSet { get; set; } 
        public IDbSet<Supplier> SupplierSet { get; set; }
        #endregion

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new UserConfiguration);
            modelBuilder.Configurations.Add(new UserRoleConfiguration);
            modelBuilder.Configurations.Add(new RoleConfiguration);
            modelBuilder.Configurations.Add(new ProductConfiguration);
            modelBuilder.Configurations.Add(new ProductTypeConfiguration);
            modelBuilder.Configurations.Add(new StockConfiguration);
            modelBuilder.Configurations.Add(new OrderConfiguration);
            modelBuilder.Configurations.Add(new SupplierConfiguration);

        }
    }
}
