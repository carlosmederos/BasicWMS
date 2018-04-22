using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BasicWMS.Data.Configurations;
using BasicWMS.Model;

namespace BasicWMS.Data
{
    public class BasicWmsContext : DbContext
    {
        
        public BasicWmsContext() : base("BasicWMS")
        {
            Database.SetInitializer<BasicWmsContext>(new DataInitialization());
        }
        
        #region Entity Sets 
        public IDbSet<Product> ProductSet { get; set; }
        public IDbSet<Category> CategorySet { get; set; } 
        #endregion

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         
            modelBuilder.Configurations.Add(new ProductConfiguration());

            base.OnModelCreating(modelBuilder);

        }
    }
}
