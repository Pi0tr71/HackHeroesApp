using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackHeroesApp.Interface;
using HackHeroesApp.Model;
using Refit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text.RegularExpressions;

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        IMyAPIReg myAPI;

        async void Register(object sender, EventArgs e)
        {
            var RegisterEmailValue = RegisterEmail.Text;
            var RegisterPassword1Value = RegisterPassword1.Text;
            var RegisterPassword2Value = RegisterPassword2.Text;
            var RegisterLoginValue = RegisterLogin.Text;
            string emailR = "a"; //Dodałem tu a bo inaczej wywala błąd że jest pusty więc regex się wywala i apka pada
            emailR += RegisterEmailValue;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); //Walidacja email
            Match match = regex.Match(emailR);
            if (!match.Success)
            {
                errorDisplay.Text = "Wpisz poprawnie email";
            }
            else if (RegisterEmailValue.Length > 39)
            {
                errorDisplay.Text = "Email jest za długi";
            }
            else if (RegisterLoginValue == null)
            {
                errorDisplay.Text = "Wpisz login";
            }
            else if (RegisterLoginValue.Length < 5)
            {
                errorDisplay.Text = "Login jest za krótki";
            }
            else if (RegisterLoginValue.Length > 40)
            {
                errorDisplay.Text = "Login jest za długi";
            }
            else if (RegisterPassword1Value == null)
            {
                errorDisplay.Text = "Podaj hasło";
            }
            else if (RegisterPassword1Value.Length < 7)
            {
                errorDisplay.Text = "Hasło jest za krótkie";
            }
            else if (RegisterPassword1Value.Length > 15)
            {
                errorDisplay.Text = "Hasło jest za długie";
            }
            else if (RegisterPassword2Value == null)
            {
                errorDisplay.Text = "Powtórz hasło";
            }
            else if (RegisterPassword1Value != RegisterPassword2Value)
            {
                errorDisplay.Text = "Hasła nie są takie same";
            }
            else
            {
                myAPI = RestService.For<IMyAPIReg>(API_ENV.API_URL);
                try
                {

                    RegPost post = new RegPost();
                    post.email = RegisterEmailValue;
                    post.haslo = RegisterPassword1Value;
                    post.login = RegisterLoginValue;
                    RegPost result = await myAPI.SubmitPost(post);
                    Console.WriteLine(result.status);
                    if (result.status == "user created")
                    {
                        await DisplayAlert("Utworzono Konto", "Teraz możesz się zalogować", "OK");
                        await Navigation.PopModalAsync();
                    }
                    if (result.status == "cant create user")
                    {
                        errorDisplay.Text = "Login lub email jest już zajęty";
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);


                }
            }
            
        }

    }
}