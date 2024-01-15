using System.ComponentModel.DataAnnotations;

namespace webServerChat.Model
{
    public class LoginParams
    {
        public int Id { get; set; }
        public string Login { get; set;}
        public string Password { get; set;}


    }
}
