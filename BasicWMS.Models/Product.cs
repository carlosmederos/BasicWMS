using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace BasicWMS.Model
{
    public class Product : IModelBase
    {
        public Product()
        {
            Stocks = new List<Stock>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string PartNumber { get; set; }

        public string Label { get; set; }

        public string Description { get; set; }

        public int StartingInventory { get; set; }

        public int InventoryReceived { get; set; }

        public int InventoryShipped { get; set; }

        public int InventoryOnHand { get; set; }

        public int MinimumRequired { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }

    }
}