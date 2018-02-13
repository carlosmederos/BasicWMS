using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Models;

namespace BasicWMS.Data.Configurations
{
    public class ProductConfiguration : ModelBaseConfiguration<Product>
    {
        public ProductConfiguration()
        {
            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(p => p.InventoryOnHand).IsRequired().HasColumnName("Inventory on Hand");
            Property(p => p.InventoryReceived).IsRequired().HasColumnName("InventoryReceived");
            Property(p => p.InventoryShipped).IsRequired().HasColumnName("Inventory Shipped");
            Property(p => p.Label).IsOptional();
            Property(p => p.MinimumRequired).IsRequired().HasColumnName("Minimum Required");
            Property(p => p.Description).IsOptional().HasMaxLength(100);
            Property(p => p.StartingInventory).IsRequired().HasColumnName("StartingInventory");

            HasMany(p => p.Stocks).WithRequired().HasForeignKey(s => s.ProductId);
        }
    }
}
