using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasicWMS.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Display(Name="Name")]
        public string ProductName { get; set; }

        [Display(Name = "Part Number")]
        public string PartNumber { get; set; }

        [Display(Name = "Label")]
        public string ProductLabel { get; set; }

        [Display(Name = "Starting Inventory")]
        public int StartingInventory { get; set; }

        [Display(Name = "Inventory Received")]
        public int InventoryReceived { get; set; }

        [Display(Name = "Inventory Shipped")]
        public int InventoryShipped { get; set; }

        [Display(Name = "Inventory On Hand")]
        public int InventoryOnHand { get; set; }

        [Display(Name = "Minimum Required")]
        public int MinimumRequired { get; set; }

    }
}