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
using HackHeroesApp.ValuesF;
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
        IMyAPIToken myAPIT;

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
                errorDisplay.Text = "Wpisz poprawnie email";
            }
            else if (LoginPasswordValue == null)
            {
                errorDisplay.Text = "Wpisz hasło";
            }

            else
            {
                myAPI = RestService.For<IMyAPILog>(API_ENV.API_URL);

                try
                {

                    LogPost post = new LogPost();
                    post.email = LoginEmailValue;
                    post.haslo = LoginPasswordValue;
                    LogPost result = await myAPI.SubmitPost(post);
                    Console.WriteLine("Tu pojawią się 3 zmienne status token i poziom");
                    Console.WriteLine(result.status);
                    Console.WriteLine(result.token);
                    Console.WriteLine(result.poziom);

                    var v = new Values(result.token, result.poziom, "a");
                    //var v = new Values(result.token, result.poziom, Values.Cos.Login);

                    if (result.status == "loged in")
                    {
                        var authHeader = Values.Cos.Token;
                        var refitSettings = new RefitSettings()
                        {
                            AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
                        };
                        Console.WriteLine(refitSettings.ToString());
                        myAPIT = RestService.For<IMyAPIToken>(API_ENV.API_URL, refitSettings);
                        TokenPost post1 = new TokenPost();
                        TokenPost result1 = await myAPIT.SubmitPost(post1);
                        Console.WriteLine(result1.login);
                        var a = new Values(Values.Cos.Token, Values.Cos.Poziom, result1.login);

                        await Navigation.PushModalAsync(new Page4());
                    }
                    if (result.status == "user not found")
                    {
                        errorDisplay.Text = "Błędny email";
                    }
                    if (result.status == "bad password")
                    {
                        errorDisplay.Text = "Błędne hasło";
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);


                }
            }

        }

        public async void GoToRegisterPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page3());
        }
    }
}