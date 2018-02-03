using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BasicWMS.Models;

namespace BasicWMS.DAL
{
    public class WmsDatabaseInitializer : DropCreateDatabaseAlways<WmsContext>
    {
        protected override void Seed(WmsContext context)
        {
            context.Suppliers.Add(new Supplier {SupplierName = "Almacenes Universales"});

            base.Seed(context);
        }
    }
}