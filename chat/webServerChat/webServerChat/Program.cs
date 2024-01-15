using Microsoft.EntityFrameworkCore;
using webServerChat.Controllers;
using webServerChat.DB;
using webServerChat.Model;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();


var app = builder.Build();

app.UseRouting();
app.UseDefaultFiles();
app.UseStaticFiles();

AuthorizationController authorizationController = new();
RegistrationController registrationController = new();
RoomController roomController = new();

            app.UseEndpoints(endpoints =>
            {
                endpoints?.MapPost("/chat/auth", async context =>
                {
                    await authorizationController.Authorization(context);
                });
                endpoints?.MapPost("/chat/reg", async context =>
                {
                    await registrationController.Registration(context);
                });
                endpoints?.MapPost("/chat/new", async context =>
                {
                    await roomController.CreateRoom(context);
                });
                endpoints?.MapPost("/chat/inchat", async context =>
                {
                    await roomController.GoInRoom(context);
                });
                endpoints?.MapGet("/chat/allrooms", async context =>
                {
                    await roomController.GetAllRooms(context);
                });
                endpoints?.MapHub<ChatHub>("/chat");
            });


app.Run();
        
   
