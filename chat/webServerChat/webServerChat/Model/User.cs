using System.ComponentModel.DataAnnotations;

namespace webServerChat.Model
{
    public class User
    {
        public int Id { get; set; } 
        public string Login { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
