using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Model;

namespace BasicWMS.Data.Configurations
{
    public class ProductTypeConfiguration : ModelBaseConfiguration<ProductType>
    {
        public ProductTypeConfiguration()
        {
            Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}
