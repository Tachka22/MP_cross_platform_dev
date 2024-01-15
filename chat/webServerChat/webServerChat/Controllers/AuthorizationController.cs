using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using webServerChat.DB;
using webServerChat.Model;

namespace webServerChat.Controllers
{
    public class AuthorizationController
    {
        Chat chat = new Chat();

        public async Task Authorization(HttpContext context)
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
                var  login = (string)(items["Login"] ?? throw new InvalidOperationException());
                var password = (string)(items["Password"] ?? throw new InvalidOperationException());

                //Console.WriteLine(login.ToString() + password.ToString());
                //Тут проверка на пользователя если он существует
                //?
                User resUser = new();
                int UserID = 0;
                string UserLogin = "";
                string UserPassword = "";
                using(DataContext db = new DataContext())
                {

                    var res = db.LoginParams.FromSqlRaw(@$"SELECT * FROM public.""LoginParams"" WHERE ""Login"" = '{login}' AND ""Password"" = '{password}';");
                    foreach (LoginParams u in res)
                    {
                        Console.WriteLine($"{u.Id}");
                        UserID = u.Id;
                        UserLogin = u.Login;
                        UserPassword = u.Password;
                    }

                    if (UserID != 0)
                    {
                        if (UserLogin == login && UserPassword == password)
                        {
                            var idUser = UserID;
                            resUser = await db.Users.FindAsync(idUser);
                        }
                        else
                        {
                            context.Response.StatusCode = 403;
                            await context.Response.WriteAsJsonAsync(new { message = "Ошибка авторизации." });
                        }
                    }
                }
                var json = JsonConvert.SerializeObject(resUser);
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
    }
}
