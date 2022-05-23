using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Vw.Respuestas
{
    public class Result
    {
        [JsonProperty("resultado")]
        public int Resultado { get; set; }
        [JsonProperty("mensaje")]
        public string Mensaje { get; set; }
    }
}
