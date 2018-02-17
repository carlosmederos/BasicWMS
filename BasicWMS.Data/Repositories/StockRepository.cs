using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Data.Infrastructure;
using BasicWMS.Model;

namespace BasicWMS.Data.Repositories
{
    public class StockRepository : RepositoryBase<Stock>, IStockRepository
    {
        public StockRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }

    public interface IStockRepository : IRepository<Stock>
    {
    }
}
