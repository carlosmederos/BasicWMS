using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Models;

namespace BasicWMS.Data.Configurations
{
    public class ModelBaseConfiguration<T> : EntityTypeConfiguration<T> where T : class, IModelBase
    {
        public ModelBaseConfiguration()
        {
            HasKey(e => e.Id);
        }
    }
}
