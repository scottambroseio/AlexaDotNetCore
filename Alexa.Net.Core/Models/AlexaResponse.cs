using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class AlexaResponse
    {
        public AlexaResponse() {}

        [JsonProperty("version")]
        public double Version { get; set;  }

        [JsonProperty("sessionAttributes")]
        public SessionAttributes SessionAttributes { get; set; }

        [JsonProperty("response")]
        public Response Response { get; set; }

        [JsonProperty("shouldEndSession")]
        public bool ShouldEndSession { get; set; }
    }
}
