using Newtonsoft.Json;

namespace Alexa.Net.Core.Models
{
    public class Slot
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
