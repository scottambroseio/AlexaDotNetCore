using Newtonsoft.Json;

namespace Alexa.Net.Core
{
    public class Card
    {
        [JsonProperty("type")]
        public CardType Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }
    }
}
