using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWMS.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Product> Productos { get; set; }
    }
}
