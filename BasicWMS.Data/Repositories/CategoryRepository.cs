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
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public Category GetByName(string name)
        {
            return DbContext.CategorySet.FirstOrDefault(c => c.Nombre == name);
        }

        public IEnumerable<Product> GetProductsByCategory(int id)
        {
            Category category = this.GetById(id);
            return category.Productos.AsEnumerable();
        } 
    }

    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetByName(string name);
        IEnumerable<Product> GetProductsByCategory(int id);
    }
}
