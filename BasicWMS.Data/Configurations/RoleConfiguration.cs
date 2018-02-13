using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Models;

namespace BasicWMS.Data.Configurations
{
    public class RoleConfiguration : ModelBaseConfiguration<Role>
    {
        public RoleConfiguration()
        {
            Property(r => r.Name).IsRequired().HasMaxLength(50);
        }
    }
}
