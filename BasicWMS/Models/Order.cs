using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BasicWMS.Models
{
    public class Order
    {

        public int OrderId { get; set; }

        public string Title { get; set; }

        public string First { get; set; }

        public string Middle { get; set; }

        public string Last { get; set; }

        public int NumberShipped { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        public Product Product { get; set; }
    }
}