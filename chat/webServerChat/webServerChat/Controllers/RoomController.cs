using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using webServerChat.DB;
using webServerChat.Model;
using Microsoft.EntityFrameworkCore;

namespace webServerChat.Controllers
{
    public class RoomController
    {
        Random rnd = new();
        public async Task CreateRoom(HttpContext context)
        {
            try
            {
                //Парсим json и передаём в модель
                string body;
                using (var sr = new StreamReader(context.Request.Body))
                    body = sr.ReadToEndAsync().Result;
                Console.WriteLine(body);
                var items = JObject.Parse(body);

                //Тут парсим
                var name = (string)(items["Name"] ?? throw new InvalidOperationException());
                var countActiveUsers = (int)(items["CountActiveUsers"] ?? throw new InvalidOperationException());

                var room = new Room
                {
                    Id = rnd.Next(10000000),
                    Name = name,
                    CountActiveUsers = countActiveUsers,
                    RoomToken = Guid.NewGuid()
                };
                using (DataContext db = new DataContext())
                {
                    await db.Rooms.AddAsync(room);
                    await db.SaveChangesAsync();
                }

                var json = JsonConvert.SerializeObject(room);
                Console.WriteLine(json);
                await context.Response.WriteAsync(json);

                context.Response.StatusCode = 200;
            }
            catch (Exception e)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsJsonAsync(new { message = "Некорректные данные." });
            }
        }
        public async Task GoInRoom(HttpContext context)
        {
            try
            {
                //Парсим json и передаём в модель
                string body;
                using (var sr = new StreamReader(context.Request.Body))
                    body = sr.ReadToEndAsync().Result;
                Console.WriteLine(body);
                var items = JObject.Parse(body);

                //Тут парсим
                var id = (int)(items["Id"] ?? throw new InvalidOperationException());

                Room room = new();
                using (DataContext db = new DataContext())
                {
                    room = await db.Rooms.FindAsync(id);
                }
                if (room != null)
                {
                    var json = JsonConvert.SerializeObject(room);
                    Console.WriteLine(json);
                    await context.Response.WriteAsync(json);
                    context.Response.StatusCode = 200;
                }
                else
                {
                    context.Response.StatusCode = 403;
                    await context.Response.WriteAsJsonAsync(new { message = $"Комнаты с id:{id} не существует." });
                }

            }
            catch (Exception e)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsJsonAsync(new { message = $"Ошибка." });
            }
        }
        public async Task GetAllRooms(HttpContext context)
        {
            List<Room> rooms = new();
            using (DataContext db = new DataContext())
            {
                rooms = await db.Rooms.ToListAsync();
            }
            var json = JsonConvert.SerializeObject(rooms);
            Console.WriteLine(json);
            await context.Response.WriteAsJsonAsync(json);
        }
    }
}
