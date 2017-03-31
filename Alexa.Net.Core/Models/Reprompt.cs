using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class Reprompt
    {
        [JsonProperty("outputSpeech")]
        public OutputSpeech OutputSpeech { get; set; }
    }
}
