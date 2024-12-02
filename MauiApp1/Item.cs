using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MauiApp1
{
    public class Item
    {
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("cost")]
        public int Cost { get; set; }
        
        [JsonPropertyName("tier_id")]
        public int Tier_id { get; set; }
        [JsonPropertyName("type_id")]
        public int Type_id { get; set; }
        [JsonPropertyName("image")]
        public string Image { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
    public class ApiResponse2
    {
        [JsonPropertyName("Предметы")]
        public List<Item> Предметы { get; set; }
    }


}


