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
    public class Character
    {
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("image")]
        public string Image { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }

public class ApiResponse
    {
        [JsonPropertyName("Персонажи")]
        public List<Character> Персонажи { get; set; }
    }


}
