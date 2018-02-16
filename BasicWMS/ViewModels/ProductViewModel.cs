using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BasicWMS.Model;
using System.Linq;
using System.Web;

namespace BasicWMS.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required(ErrorMessage = "Please, enter part number")]
        public string PartNumber { get; set; }

        public string Label { get; set; }

        public string Description { get; set; }

        [Required]
        [DisplayName("Starting Inventory")]
        public int StartingInventory { get; set; }

        [Required]
        [DisplayName("Inventory Received")]
        public int InventoryReceived { get; set; }

        [Required]
        [DisplayName("Inventory Shipped")]
        public int InventoryShipped { get; set; }

        [Required]
        [DisplayName("Inventory on Hand")]
        public int InventoryOnHand { get; set; }

        [Required]
        [DisplayName("Minimum Required")]
        public int MinimumRequired { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}