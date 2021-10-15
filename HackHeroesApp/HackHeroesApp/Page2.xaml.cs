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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        IMyAPILog myAPI;

        async void Login(object sender, EventArgs e)
        {
            var LoginEmailValue = LoginEmail.Text;
            var LoginPasswordValue = LoginPassword.Text;
            string emailL = "a"; //Dodałem tu a bo inaczej wywala błąd że jest pusty więc regex się wywala i apka pada
            emailL += LoginEmailValue;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); //Walidacja email
            Match match = regex.Match(emailL);
            if (!match.Success)
            {
                Console.WriteLine("Wpisz poprawnie email");
            }
            else if (LoginPasswordValue == null)
            {
                Console.WriteLine("Brak Hasła");
            }

            else
            {
                myAPI = RestService.For<IMyAPILog>("http://192.168.0.180:5000/api/v1");
                try
                {

                    LogPost post = new LogPost();
                    post.email = LoginEmailValue;
                    post.haslo = LoginPasswordValue;
                    LogPost result = await myAPI.SubmitPost(post);
                    Console.WriteLine(result.status);
                    Console.WriteLine(result.token);
                    Console.WriteLine(result.poziom);
                    if (result.status == "loged in")
                    {
                        await Navigation.PushModalAsync(new Page4());
                    }
                    if (result.status == "user not found")
                    {
                        Console.WriteLine("Błędne email");
                    }
                    if (result.status == "bad password")
                    {
                        Console.WriteLine("Błędne Hasło");
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