using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Model;
using System.Data.Entity.ModelConfiguration;

namespace BasicWMS.Data.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("Products");
            HasKey(p => p.Id);
            Property(p => p.Codigo).IsRequired().HasMaxLength(50);
            Property(p => p.Nombre).IsRequired().HasMaxLength(30);
            Property(p => p.CantidadDisponible).IsRequired();
            Property(p => p.CantidadMinima);
            Property(p => p.Descripcion);
            Property(p => p.Disponible);
        }
    }
}
