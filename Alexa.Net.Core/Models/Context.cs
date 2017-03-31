using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class Context
    { 
        [JsonProperty("System")]
        public System System { get; set; }

        //[JsonProperty("AudioPlayer")]
        //public AudioPlayer AudioPlayer { get; set; }
    }
}
