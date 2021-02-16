using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Gw2.Models.BaseModels
{
    public class ItemComplete
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("chat_link")]
        public string ChatLink { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        //[JsonProperty("id")]
        //public string Type { get; set; }
    }
}
