using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWMS.Models
{
    public class Supplier : IModelBase
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Address { get; set; }
        
        public string Email { get; set; }

        public Guid UniqueKey { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string Mobile { get; set; }

    }
}