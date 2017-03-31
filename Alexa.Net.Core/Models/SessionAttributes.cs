using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Alexa.Net.Core
{
    [JsonConverter(typeof(SessionAttributesConverter))]
    public class SessionAttributes : IEnumerable
    {

        public Dictionary<string, object> Attributes { get; set; } = new Dictionary<string, object>();

        public IEnumerator GetEnumerator()
        {
            return Attributes.GetEnumerator();
        }

        private sealed class SessionAttributesConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return (objectType == typeof(SessionAttributes));
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JObject jo = JObject.Load(reader);
                SessionAttributes wrapper = new SessionAttributes();
                wrapper.Attributes = jo.ToObject<Dictionary<string, object>>();

                return wrapper;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                JObject jo = JObject.FromObject(((SessionAttributes)value).Attributes);
                jo.WriteTo(writer);
            }
        }
    }
}
