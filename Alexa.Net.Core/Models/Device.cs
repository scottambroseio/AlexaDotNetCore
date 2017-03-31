using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class Device
    {
        [JsonProperty("supportedInterfaces")]
        public SupportedInterfaces SupportedInterfaces { get; set; }
    }
}
