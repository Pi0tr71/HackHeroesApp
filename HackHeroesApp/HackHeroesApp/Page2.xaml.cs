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

        IMyAPI myAPI;

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
                myAPI = RestService.For<IMyAPI>("https://jsonplaceholder.typicode.com");
                try
                {
                    PostContent post = new PostContent();
                    post.userId = 1;
                    PostContent result = await myAPI.SubmitPost(post);
                    Console.WriteLine(result.id);
                    if (result.id == 101)
                    {
                        await Navigation.PushModalAsync(new Page4());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Przycisk");
                    Console.WriteLine(ex);

                }
            }

        }
    }
}