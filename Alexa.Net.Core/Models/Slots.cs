using Alexa.Net.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Alexa.Net.Core
{
    [JsonConverter(typeof(SlotsConverter))]
    public class Slots : IEnumerable
    {

        public Dictionary<string, Slot> Pairs { get; set; } = new Dictionary<string, Slot>();

        public IEnumerator GetEnumerator()
        {
            return Pairs.GetEnumerator();
        }

        private sealed class SlotsConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return (objectType == typeof(SlotsConverter));
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JObject jo = JObject.Load(reader);
                Slots wrapper = new Slots();
                wrapper.Pairs = jo.ToObject<Dictionary<string, Slot>>();

                return wrapper;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                JObject jo = JObject.FromObject(((Slots)value).Pairs);
                jo.WriteTo(writer);
            }
        }
    }
}
