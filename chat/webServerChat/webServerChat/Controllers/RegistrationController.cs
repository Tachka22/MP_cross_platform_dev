using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using webServerChat.DB;
using webServerChat.Model;

namespace webServerChat.Controllers
{
    public class RegistrationController : ControllerBase
    {
        Random random = new();

        Chat chat = new();

        public async Task Registration(HttpContext context)
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
                var login = (items["Login"] ?? throw new InvalidOperationException());
                var password = (items["Password"] ?? throw new InvalidOperationException());
                var name = (items["Name"] ?? throw new InvalidOperationException());
                var id = (int)(items["Id"] ?? throw new InvalidOperationException());
                var phoneNumber = (items["PhoneNumber"] ?? throw new InvalidOperationException());

                //Заполянем модели
                var user = new User
                {
                    Id = id,
                    Name = name.ToString(),
                    PhoneNumber = phoneNumber.ToString(),
                    Login = login.ToString()
                };

                var loginParam = new LoginParams()
                {
                    Id = id,
                    Login = login.ToString(),
                    Password = password.ToString()
                };

                using (DataContext db = new DataContext())
                {
                    await db.Users.AddAsync(user);
                    await db.LoginParams.AddAsync(loginParam);
                    db.SaveChanges();
                }


                //Отправить статус кода
                context.Response.StatusCode = 200;
            }
            catch (Exception e)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsJsonAsync(new { message = "Некорректные данные" });
            }
        }
    }
}
