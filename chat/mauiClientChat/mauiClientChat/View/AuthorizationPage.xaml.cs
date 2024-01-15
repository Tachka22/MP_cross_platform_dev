using System.Net;
using System.Text;
using mauiClientChat.Model;
using Newtonsoft.Json;

namespace mauiClientChat;

public partial class AuthorizationPage : ContentPage
{
	public AuthorizationPage()
	{
		InitializeComponent();
        btn_Authorization.Clicked += Btn_Authorization_Clicked;
        btn_Registrations.Clicked += Btn_Registrations_Clicked;
	}

    private  async void Btn_Registrations_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegistrationsPage());
    }

    private async void Btn_Authorization_Clicked(object sender, EventArgs e)
    {
        var login = ent_Login.Text;
        var password = ent_Password.Text;
        var httpClient = new HttpClient();
        httpClient.DefaultRequestVersion = HttpVersion.Version10;

        var loginParams = new LoginParams() { 
            UserReference = login,
            Password = password };

        var content = new StringContent(JsonConvert.SerializeObject(loginParams), Encoding.UTF8, "application/json");

        HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7168/chat/auth", content);

        //HttpContent responseContent = response.Content;
        //var json = await responseContent.ReadAsStringAsync();
        var responseContent = await response.Content.ReadAsStringAsync();

        //Принимаю данные от пользователя


        if (response.StatusCode == HttpStatusCode.OK)
        {
            var authorization = JsonConvert.DeserializeObject<User>(responseContent);
            await Navigation.PushAsync(new StartupPage(authorization));
        }
        else
        {
            await DisplayAlert("Ошибка авторизации", "Повторите попытку", "Ок");
        }
        
    }       
}