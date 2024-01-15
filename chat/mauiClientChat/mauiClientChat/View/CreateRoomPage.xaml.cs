using System.Net;
using System.Text;
using mauiClientChat.Model;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;

namespace mauiClientChat;

public partial class CreateRoomPage : ContentPage
{
    private HubConnection _hubConnection;
    private User _user;
    private string idRoom;
    Random rnd = new();
    public CreateRoomPage(User user, HubConnection conn)
	{
        _user = user;
        _hubConnection = conn;

		InitializeComponent();
        btn_CreateRoom.Clicked += Btn_CreateRoom_Clicked;
	}

    private async  void Btn_CreateRoom_Clicked(object sender, EventArgs e)
    {
        var nameRoom = ent_RoomName.Text;
        ent_RoomName.Text = string.Empty;

        var httpClient = new HttpClient();
        httpClient.DefaultRequestVersion = HttpVersion.Version10;

        var room = new Room
        {
            Name = nameRoom,
            CountActiveUsers = 1
        };

        var content = new StringContent(JsonConvert.SerializeObject(room), Encoding.UTF8, "application/json");

        HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7168/chat/new", content);

        var responseContent = await response.Content.ReadAsStringAsync();



        if (response.StatusCode == HttpStatusCode.OK)
        {
            var _room = JsonConvert.DeserializeObject<Room>(responseContent);
            
            await Navigation.PushAsync(new ChatPage(_user, _room, _hubConnection));

            string userGroup = _room.Id.ToString();
            await _hubConnection.InvokeAsync("Enter", _user.Name, userGroup);
        }
        else
        {
            //await DisplayAlert("Ошибка", "Повторите попытку", "Ок");
        }
    }
}