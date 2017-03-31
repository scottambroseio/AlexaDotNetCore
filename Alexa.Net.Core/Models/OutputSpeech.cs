using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class OutputSpeech
    {
        [JsonProperty("type")]
        public OutputSpeechType Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("ssml")]
        public string SSML { get; set; }
    }
}
