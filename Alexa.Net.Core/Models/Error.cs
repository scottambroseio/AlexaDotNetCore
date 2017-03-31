using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class Error
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
