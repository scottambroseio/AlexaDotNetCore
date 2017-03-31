using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class AudioPlayer
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("offsetInMilliseconds")]
        public long OffsetInMilliseconds  { get; set; }

        // MAKE ENUM
        [JsonProperty("playerActivity")]
        public PlayerActivityType PlayerActivity { get; set; }
    }
}
