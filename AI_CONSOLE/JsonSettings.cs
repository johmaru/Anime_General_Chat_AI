using Newtonsoft.Json;

namespace Chat_AI.AI_CONSOLE
{
    [JsonObject("Settings")]
    class JsonSettings
    {
        [JsonProperty("API_KEY")]
        public string APIKEY { get; set; }

        [JsonProperty("Organization")]

        public string Organization { get; set; }
    }
}
