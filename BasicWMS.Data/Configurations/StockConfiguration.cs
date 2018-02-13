using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Model;

namespace BasicWMS.Data.Configurations
{
    public class StockConfiguration : ModelBaseConfiguration<Stock>
    {
        public StockConfiguration()
        {
            Property(s => s.IsAvailable).IsRequired();
            Property(s => s.ProductId).IsRequired();
            Property(s => s.UniqueKey).IsRequired();

            HasMany(s => s.Orders).WithRequired(o => o.Stock).HasForeignKey(o => o.Stock);
        }
    }
}
