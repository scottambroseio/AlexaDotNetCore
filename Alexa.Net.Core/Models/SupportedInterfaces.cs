using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Alexa.Net.Core
{
    [JsonConverter(typeof(SupportedInterfacesConverter))]
    public class SupportedInterfaces : IEnumerable
    {
        public Dictionary<string, object> Interfaces { get; set; }

        public IEnumerator GetEnumerator()
        {
            return Interfaces.GetEnumerator();
        }

        private sealed class SupportedInterfacesConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return (objectType == typeof(SupportedInterfaces));
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JObject jo = JObject.Load(reader);
                SupportedInterfaces wrapper = new SupportedInterfaces();
                wrapper.Interfaces = jo.ToObject<Dictionary<string, object>>();

                return wrapper;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                JObject jo = JObject.FromObject(((SupportedInterfaces)value).Interfaces);
                jo.WriteTo(writer);
            }
        }
    }
}
