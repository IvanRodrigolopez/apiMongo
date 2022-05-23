using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Vw.Users
{
    public class VwUser
    {
        [BsonId]
        [JsonProperty("id")]
        public string _id { get; set; }
        [JsonProperty("usuario")]
        public string Usuario { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }
        [JsonProperty("apellidos")]
        public string Apellidos { get; set; }
        [JsonProperty("fecha_ingreso")]
        public DateTime FechaIngreso { get; set; }
        [JsonProperty("activo")]
        public bool Activo { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }



    }
}
