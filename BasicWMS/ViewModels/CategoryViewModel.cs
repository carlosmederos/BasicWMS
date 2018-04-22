using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BasicWMS.Model;
using Newtonsoft.Json;

namespace BasicWMS.ViewModels
{
    public class CategoryViewModel
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "nombre")]
        public string Nombre { get; set; }

        [JsonProperty(PropertyName = "productos")]
        public virtual ICollection<Product> Productos { get; set; }  
    }
}