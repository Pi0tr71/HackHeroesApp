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
                Console.WriteLine("Wpisz poprawnie email");
            }
            if (RegisterEmailValue.Length > 39)
            {
                Console.WriteLine("Za długi email");
            }
            else if (RegisterLoginValue == null)
            {
                Console.WriteLine("Brak Loginu");
            }
            else if (RegisterLoginValue.Length < 5)
            {
                Console.WriteLine("Login za krótki");
            }
            else if (RegisterLoginValue.Length > 40)
            {
                Console.WriteLine("Login za długi");
            }
            else if (RegisterPassword1Value == null)
            {
                Console.WriteLine("Brak hasła1");
            }
            else if (RegisterPassword1Value.Length < 7)
            {
                Console.WriteLine("Hasło za krótkie");
            }
            else if (RegisterPassword1Value.Length > 15)
            {
                Console.WriteLine("Hasło za długie");
            }
            else if (RegisterPassword2Value == null)
            {
                Console.WriteLine("Brak hasła2");
            }
            else if (RegisterPassword1Value != RegisterPassword2Value)
            {
                Console.WriteLine("Hasła nie są takie same");
            }

            else
            {
                myAPI = RestService.For<IMyAPIReg>("http://192.168.0.180:5000/api/v1");
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
                        Console.WriteLine("Login lub Email są już zajęte");
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