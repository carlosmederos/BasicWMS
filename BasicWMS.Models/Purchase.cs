using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasicWMS.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public int NumberReceived { get; set; }

        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }

        public Supplier Supplier { get; set; }

        public Product Product { get; set; }

    }
}