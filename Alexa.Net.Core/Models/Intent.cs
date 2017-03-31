using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class Intent
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slots")]
        public Slots Slots { get; set; }
    }
}
