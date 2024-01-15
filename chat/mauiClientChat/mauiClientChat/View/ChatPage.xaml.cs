
using System;
using mauiClientChat.Model;
using Microsoft.AspNetCore.SignalR.Client;

namespace mauiClientChat;
//4e19c13d-cab0-467b-8776-423eaee61f2a
public partial class ChatPage : ContentPage
{
	private  HubConnection _connection;

	private  User _user;
	private  Room _room;
	private string userGroup;
    private int n = 0;
    private string senderUser;

    public ChatPage(User user,Room room, HubConnection connection)
	{
		_user = user?? throw new ArgumentNullException(nameof(user));
        _room= room;
        _connection = connection ?? throw new ArgumentNullException(nameof(connection));

        Title = "";

		InitializeComponent();
        label_ChatName.Text = _room.Name;
        label_IdRoom.Text = _room.Id.ToString();

        _connection.On<string>("Notify", (message) =>
        {
            chatMessage.Text += $"{Environment.NewLine}{message}";
            chatMessageMi.Text += $"{Environment.NewLine}\n";
        });
        _connection.On<string, string>("ReceiveGroup", (message, username) =>
        {
            senderUser = username;

            if (senderUser == _user.Name)
            {
                chatMessageMi.Text += $"{Environment.NewLine} Вы:   {message}";
                chatMessageMi.HorizontalOptions = LayoutOptions.End;
                chatMessageMi.HorizontalTextAlignment = TextAlignment.End;
                chatMessage.Text += $"{Environment.NewLine}\t\t\t";
            }
            else
            {
                chatMessage.Text += $"{Environment.NewLine} {username}:   {message}";
                chatMessage.HorizontalOptions = LayoutOptions.Start;
                chatMessage.HorizontalTextAlignment = TextAlignment.Start;
                chatMessageMi.Text += $"{Environment.NewLine}\t\t\t";
            }
        });

  //      Task.Run(() =>
		//{
		//	Dispatcher.Dispatch(async () =>
  //          await _connection.StartAsync());
             

  //          //chatMessage.Text = $"{Environment.NewLine}Пользователь {_user.Name}\tприсоединился.";
  //      });
         
    }
    private  async void  sendBtn_Clicked(object sender, EventArgs e)
    {
        userGroup = _room.Id.ToString();
        
        try
		{
            if (myChatMessage.Text != string.Empty)
            {
                //await _connection.InvokeAsync("SendMessage", _user.Name, myChatMessage.Text);
                await _connection.InvokeAsync("SendGroup", myChatMessage.Text, _user.Name, userGroup);
                myChatMessage.Text = String.Empty;
            }
        }
        catch (Exception ex)
        {
            myChatMessage.Text = ex.Message;
        }
    }
}