using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class Application
    {
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }
    }
}
