using System.ComponentModel.DataAnnotations;
using BasicWMS.Model;
using Newtonsoft.Json;

namespace BasicWMS.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "codigo")]
        public string Codigo { get; set; }

        [JsonProperty(PropertyName = "nombre")]
        public string Nombre { get; set; }

        [JsonProperty(PropertyName = "cantidadDisponibe")]
        public int CantidadDisponible { get; set; }

        [JsonProperty(PropertyName = "cantidadMinima")]
        public int CantidadMinima { get; set; }

        [JsonProperty(PropertyName = "descripcion")]
        public string Descripcion { get; set; }

        private bool _disponible;
        [JsonProperty(PropertyName = "disponible")]
        public bool Disponible
        {
            get
            {
                _disponible = CantidadMinima <= CantidadDisponible;
                return _disponible;
            }
            set { _disponible = CantidadMinima <= CantidadDisponible; }
        }

        [JsonProperty(PropertyName = "categoriaId")]
        public int CategoriaId { get; set; }
        
        [JsonProperty(PropertyName = "categoria")]
        public virtual Category Categoria { get; set; }
    }
}