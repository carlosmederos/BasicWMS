using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Data.Infrastructure;
using BasicWMS.Models;

namespace BasicWMS.Data.Repositories
{
    public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {
        public SupplierRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }

    public interface ISupplierRepository : IRepository<Supplier>
    {
         
    }
}
