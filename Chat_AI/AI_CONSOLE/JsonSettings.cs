using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AI_CONSOLE
{
    public class JsonSettings
    {
        [JsonProperty("API_KEY")]
        public string APIKEY { get; set; }

        [JsonProperty("Organization")]

        public string Organization { get; set; }
    }
}
