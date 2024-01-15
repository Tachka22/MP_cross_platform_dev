using System;
using System.Diagnostics.Metrics;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using mauiClientChat.Model;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Maui.Controls.Compatibility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace mauiClientChat;

public partial class StartupPage : ContentPage
{
    private HubConnection hubConnection;
    private User _user;
    private List<Room> Rooms { get; set; }
    public StartupPage(User user)
    {
        InitializeComponent();
        _user = user;

        btn_CreateDialog.Clicked += Btn_CreateDialog_Clicked;
        btn_EnterDilog.Clicked += Btn_EnterDilog_Clicked;

        label_UserName.Text = $"{_user.Name}";
        label_Status.Text = "Онлайн";

        //Запускаем хаб
        hubConnection = new HubConnectionBuilder()
    .WithUrl("https://localhost:7168/chat")
    .WithAutomaticReconnect()
    .Build();
        hubConnection.StartAsync();


        //GetAllRooms();




        Rooms = new List<Room>
        {
            new Room {Name = "Комната 1", Id = 1},
            new Room {Name = "Комната 2", Id = 1},
            new Room {Name = "Комната 3", Id = 1},
            new Room {Name = "Комната 4", Id = 1},
        };
        ListView roomsListView = new ListView();
        roomsListView.ItemsSource = Rooms;

        roomsListView.ItemTemplate = new DataTemplate(() =>
        {
            // привязка к свойству Name
            Label nameLabel = new Label { FontSize = 16 };
            nameLabel.SetBinding(Label.TextProperty, "Name");

            // привязка к свойству Age
            Label idLabel = new Label { FontSize = 14 };
            idLabel.SetBinding(Label.TextProperty, "Id");

            // создаем объект ViewCell.
            return new ViewCell
            {
                View = new Microsoft.Maui.Controls.StackLayout
                {
                    Padding = new Thickness(0, 5),
                    Orientation = StackOrientation.Vertical,
                    Children = { nameLabel, idLabel }
                }
            };
        });
        //Content = new StackLayout { Children = { roomsListView }, Padding = 7, };
        StackL.Add(new Microsoft.Maui.Controls.StackLayout { Children = { roomsListView }, Padding = 7, });
    }
    private async void  GetAllRooms()
    {
        var httpClient = new HttpClient();
        httpClient.DefaultRequestVersion = HttpVersion.Version10;
        var response = await httpClient.GetAsync("https://localhost:7168/chat/allrooms");
        var responseContent = await response.Content.ReadAsStringAsync();


        
        //List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(responseContent);
        //List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(responseContent);
        //List<Room> rooms = JsonSerializer.Deserialize<List<Room>>(responseContent);
    }
    private async void Btn_EnterDilog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage(hubConnection, _user));
    }

    private async void Btn_CreateDialog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateRoomPage(_user, hubConnection));
    }
}