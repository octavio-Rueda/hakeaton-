using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace WebGuiaCesar.Models
{
    public class Calificacion
    {
         [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Name")]
        public string Nombre { get; set; }


    }
}