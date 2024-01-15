using System.Net;
using System.Net.Http;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using mauiClientChat.Model;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Maui.ApplicationModel.Communication;
using Newtonsoft.Json;
using static Microsoft.Maui.ApplicationModel.Permissions;


//4e19c13d-cab0-467b-8776-423eaee61f2a
namespace mauiClientChat;

public partial class MainPage : ContentPage
{
    Random rnd = new();

    private HubConnection _hubConnection;
    private User _user;
	public MainPage(HubConnection conn, User user)
	{
		InitializeComponent();
        _hubConnection = conn;
        _user = user;

        InChat.Clicked += InChat_Clicked;
        token.TextChanged+= token_TextChanged;
    }

    private async void  InChat_Clicked(object sender, EventArgs e)
	{
        string idString = token.Text;

        var httpClient = new HttpClient();
        httpClient.DefaultRequestVersion = HttpVersion.Version10;

        var roomId = new Room
        {
            Id = int.Parse(idString)
        };

        var content = new StringContent(JsonConvert.SerializeObject(roomId), Encoding.UTF8, "application/json");

        HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7168/chat/inchat", content);

        var responseContent = await response.Content.ReadAsStringAsync();

        if (response.StatusCode == HttpStatusCode.OK)
        {
            var room = JsonConvert.DeserializeObject<Room>(responseContent);

            await DisplayAlert("Вы вошли как:", $"Имя: {_user.Name}\nid:{_user.Id}", "ок");

            await Navigation.PushAsync(new ChatPage(_user, room, _hubConnection));

            //добавялние в группу и оповещение
            await _hubConnection.InvokeAsync("Enter", _user.Name, idString);
        }
           

    }

    private void token_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(!string.IsNullOrWhiteSpace(token.Text))
            InChat.IsEnabled= true;
        else
            InChat.IsEnabled = false;

    }
}

