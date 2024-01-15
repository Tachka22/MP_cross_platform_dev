using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mauiClientChat.Model
{
    /// <summary>
    /// Команата.
    /// </summary>
    public class Room
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("RoomToken")]
        public Guid RoomToken { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("CountActiveUsers")]
        public int CountActiveUsers { get; set; }

    }
}
