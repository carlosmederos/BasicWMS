using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWMS.Models
{
    public class Order : IModelBase
    {

        public int Id { get; set; }

        public int SupplierId { get; set; }

        public int StockId { get; set; }

        public int NumberShipped { get; set; }

        public string Status { get; set; }

        public DateTime OrderDate { get; set; }

        public virtual Stock Stock { get; set; }
    }
}