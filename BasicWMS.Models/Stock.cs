using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWMS.Model
{
    public class Stock : IModelBase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public Guid UniqueKey { get; set; }
        public bool IsAvailable { get; set; }

        public virtual ICollection<Order> Orders  { get; set; }
    }
}
