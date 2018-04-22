using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace BasicWMS.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public int CantidadDisponible { get; set; }

        public int CantidadMinima { get; set; }

        public string Descripcion { get; set; }

        private bool _disponible;
        public bool Disponible
        {
            get
            {
                _disponible = CantidadMinima <= CantidadDisponible;
                return _disponible;
            }
            set { _disponible = CantidadMinima <= CantidadDisponible; }
        }

        public int CategoriaId { get; set; }

        public virtual Category Categoria { get; set; }

    }
}