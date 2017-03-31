using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class AlexaRequest
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("session")]
        public Session Session { get; set; } = new Session();

        [JsonProperty("context")]
        public Context Context { get; set; } = new Context();

        [JsonProperty("request")]
        public Request Request { get; set; } = new Request();
    }
}
