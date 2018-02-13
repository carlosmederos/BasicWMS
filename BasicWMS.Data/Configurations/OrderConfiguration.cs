using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Model;

namespace BasicWMS.Data.Configurations
{
    public class OrderConfiguration : ModelBaseConfiguration<Order>
    {
        public OrderConfiguration()
        {
            Property(o => o.NumberShipped).IsRequired();
            Property(o => o.OrderDate).IsRequired();
            Property(o => o.Status).IsRequired().HasMaxLength(20);
            Property(o => o.StockId).IsRequired();
            Property(o => o.SupplierId).IsRequired();
        }
    }
}
