using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Models;

namespace BasicWMS.Data.Configurations
{
    public class SupplierConfiguration : ModelBaseConfiguration<Supplier>
    {
        public SupplierConfiguration()
        {
            Property(s => s.Name).IsRequired().HasMaxLength(50);
            Property(s => s.Email).IsRequired().HasMaxLength(100);
            Property(s => s.Mobile).IsRequired();
            Property(s => s.RegistrationDate).IsRequired();
            Property(s => s.UniqueKey).IsRequired();
        }
    }
}
