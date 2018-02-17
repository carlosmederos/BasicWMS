using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Model;

namespace BasicWMS.Data
{
    public class BasicWmsContextSeedData : DropCreateDatabaseIfModelChanges<BasicWmsContext>
    {
        protected override void Seed(BasicWmsContext context)
        {
            context.RoleSet.AddOrUpdate(r => r.Name, GenerateRoles());

            context.UserSet.AddOrUpdate(u => u.Email, new User[]
            {
                new User()
                {
                    Email = "krlosmederos@gmail.com",
                    Username = "krlosmederos",
                    HashedPassword = "asdasd",
                    Salt = "axzccz",
                    DateCreated = DateTime.Now,
                    IsLocked = false
                }
            });

            context.UserRoleSet.AddOrUpdate(new UserRole[]
            {
                new UserRole()
                {
                    RoleId = 1,
                    UserId = 1
                }
            });
        }

        private Role[] GenerateRoles()
        {
            var roles = new Role[]
            {
                new Role()
                {
                    Name = "Admin"
                }
            };
            return roles;
        }
    }
}
