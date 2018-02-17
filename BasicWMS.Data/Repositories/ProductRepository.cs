using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Data.Infrastructure;
using BasicWMS.Model;

namespace BasicWMS.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public Product GetByName(string name)
        {
            return this.DbContext.ProductSet.Where(p => p.Name == name).FirstOrDefault();
        }
    }

    public interface IProductRepository : IRepository<Product>
    {
        Product GetByName(string name);
    }
}
