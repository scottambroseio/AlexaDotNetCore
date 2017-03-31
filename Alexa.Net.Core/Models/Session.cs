using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class Session
    {
        [JsonProperty("new")]
        public bool New { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("application")]
        public Application Application { get; set; }

        [JsonProperty("attributes")]
        public SessionAttributes Attributes { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}
