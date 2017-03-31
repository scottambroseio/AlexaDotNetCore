using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class Response
    {
        [JsonProperty("outputSpeech")]
        public OutputSpeech OutputSpeech { get; set; }

        [JsonProperty("card")]
        public Card Card { get; set; }

        [JsonProperty("reprompt")]
        public Reprompt Reprompt { get; set; }
    }
}
