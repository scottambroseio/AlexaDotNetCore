using Newtonsoft.Json;
using System;

namespace Alexa.Net.Core
{
    [JsonConverter(typeof(RequestTypeConverter))]
    public sealed class RequestType
    {
        private readonly string name;
        private readonly int value;

        public static readonly RequestType LaunchRequest = new RequestType(1, "LaunchRequest");
        public static readonly RequestType IntentRequest = new RequestType(2, "IntentRequest");
        public static readonly RequestType SessionEndedRequest = new RequestType(3, "SessionEndedRequest");

        private RequestType(int value, string name)
        {
            this.name = name;
            this.value = value;
        }

        public override string ToString()
        {
            return name;
        }

        private sealed class RequestTypeConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return (objectType == typeof(RequestType));
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                string type = (string)reader.Value;

                if (type == LaunchRequest.ToString())
                    return LaunchRequest;
                else if (type == IntentRequest.ToString())
                    return IntentRequest;
                else if (type == SessionEndedRequest.ToString())
                    return SessionEndedRequest;

                throw new Exception($"RequestTypeConverter.ReadJson: {type} is invalid");
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                writer.WriteValue(value.ToString());
            }
        }
    }
}
