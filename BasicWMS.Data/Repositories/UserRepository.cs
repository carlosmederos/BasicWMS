using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Data.Infrastructure;
using BasicWMS.Model;

namespace BasicWMS.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }

    public interface IUserRepository : IRepository<User>
    {
         
    }
}
