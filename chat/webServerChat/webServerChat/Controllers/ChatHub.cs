using Microsoft.AspNetCore.SignalR;
using webServerChat.DB;
using webServerChat.Model;

namespace webServerChat.Controllers
{
    public class ChatHub : Hub
    {
        //мб список комнат
        private User? _user;
        private Room? _room = new();
        public async Task SendMessage(string username, string message)
        {
            await Clients.All.SendAsync("MessageReceived", username, message);
        }
        public async Task Enter(string userName, string groupName)
        {
            Console.WriteLine(groupName);

            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("Notify", $"{userName} присоединился.");

        }
        public async Task SendGroup(string message, string userName, string groupName)
        {
            await Clients.Group(groupName).SendAsync("ReceiveGroup", message, userName);
        }
        public Task ImageMessage(ImageMessage file)
        {
            return Clients.All.SendAsync("ImageMessage", file);
        }
    }
}
