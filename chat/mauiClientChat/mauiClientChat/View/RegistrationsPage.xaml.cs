using System.Net;
using System.Text;
using mauiClientChat.Model;
using Newtonsoft.Json;

namespace mauiClientChat;

public partial class RegistrationsPage : ContentPage
{
    Random rnd = new();
    private Model.User _user;
	public RegistrationsPage()
	{
		InitializeComponent();
        btn_Registrations.Clicked += Btn_Registrations_Clicked;
	}

    private  async void Btn_Registrations_Clicked(object sender, EventArgs e)
    {
        var login = ent_LoginReg.Text;
        var name = ent_NameReg.Text;
        var phoneNumber = ent_PhoneNumberReg.Text;
        var password = ent_PasswordReg.Text;
        var password2 = ent_RepPasswordReg.Text;

        if(password != password2)
            await DisplayAlert("Ошибка", "Пароли не совпадают", "Ок");

        var httpClient = new HttpClient();

        var _user = new Model.User
        {
            Id = rnd.Next(1000000),
            Name = name,
            Login = login,
            Password = password,
            PhoneNumber = phoneNumber
        };
        var content = new StringContent(JsonConvert.SerializeObject(_user), Encoding.UTF8, "application/json");

        HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7168/chat/reg", content);
        var responseContent = await response.Content.ReadAsStringAsync();

        if (response.StatusCode == HttpStatusCode.OK)
        {
            await Navigation.PushAsync(new StartupPage(_user));
        }
        else
        {
            await DisplayAlert("Ошибка регистрации", "Повторите попытку", "Ок");
        }

    }
}