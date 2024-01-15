using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mauiClientChat.Model
{
    public class User
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("Login")]
        public string Login { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        //[JsonProperty("status")]
        //public bool Status { get; set; } = false;
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }
    }
}
