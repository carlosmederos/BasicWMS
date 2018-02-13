using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWMS.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BasicWmsContext _dbContext;

        public BasicWmsContext Init()
        {
            return _dbContext ?? (_dbContext = new BasicWmsContext());
        }

        protected override void DisposeCore()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}
