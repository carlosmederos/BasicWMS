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

        public Product GetByName(string nombre)
        {
            return DbContext.ProductSet.FirstOrDefault(p => p.Nombre == nombre);
        }

        public IEnumerable<Product> GetProductForPage(int pageSize, int numPage)
        {
            return DbContext.ProductSet.Skip(pageSize*(numPage-1)).Take(pageSize);
        } 
    }

    public interface IProductRepository : IRepository<Product>
    {
        Product GetByName(string name);
        IEnumerable<Product> GetProductForPage(int pageSize, int numPage);
    }
}
