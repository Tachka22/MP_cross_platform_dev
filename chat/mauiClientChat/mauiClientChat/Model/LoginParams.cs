using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Newtonsoft.Json;

namespace mauiClientChat.Model
{
    internal class LoginParams
    {
        public LoginParams()
        {

        }
        /// <summary>
        /// Unique user reference
        /// </summary>
        [JsonProperty("Login")]
        [MaxLength(20)]
        public string UserReference { get; set; }

        /// <summary>
        /// Password used by user
        /// </summary>
        [JsonProperty("Password")]
        public string Password { get; set; }
    }
}