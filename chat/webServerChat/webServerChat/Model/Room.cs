using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webServerChat.Model
{
    public class Room
    {
        public int Id { get; set; }
        public Guid RoomToken { get; set; }
        public string Name { get; set; }
        public int CountActiveUsers { get; set; }
    }
}
