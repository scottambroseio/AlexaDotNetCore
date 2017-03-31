using Newtonsoft.Json;
using System;

namespace Alexa.Net.Core
{
    public class Request
    {
        [JsonProperty("type")]
        public RequestType Type { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("intent")]
        public Intent Intent { get; set; }

        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public ReasonType Reason { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorType Error { get; set; }
    }
}
