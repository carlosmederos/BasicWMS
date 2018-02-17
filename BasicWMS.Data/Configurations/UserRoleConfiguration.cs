using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Model;

namespace BasicWMS.Data.Configurations
{
    public class UserRoleConfiguration : ModelBaseConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            Property(u => u.UserId).IsRequired();
            Property(u => u.RoleId).IsRequired();
        }
    }
}
