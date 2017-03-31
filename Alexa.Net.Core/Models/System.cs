using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class System
    {
        [JsonProperty("application")]
        public Application Application { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("device")]
        public Device Device { get; set; }
    }
}
