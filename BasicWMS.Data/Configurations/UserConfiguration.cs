using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Model;

namespace BasicWMS.Data.Configurations
{
    public class UserConfiguration : ModelBaseConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(u => u.Username).IsRequired().HasMaxLength(50);
            Property(u => u.Email).IsRequired().HasMaxLength(50);
            Property(u => u.HashedPassword).IsRequired().HasMaxLength(50);
            Property(u => u.Salt).IsRequired().HasMaxLength(50);
            Property(u => u.IsLocked).IsRequired();
            Property(u => u.DateCreated);
        }
    }
}
