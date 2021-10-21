using HackHeroesApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HackHeroesApp.ValuesF;
using HackHeroesApp.Interface;
using HackHeroesApp.Model;
using Refit;


namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : TabbedPage
    {
        private List<UserRanking> usersColors = new List<UserRanking>();

        public Page4()
        {
            InitializeComponent();
            PoziomText.Text = "Poziom " + Values.instance.Level; 
            LoginText.Text = Values.instance.Login;
            LoadStatsForProfile();
            GenerateRanking();
        }

        async void LoadStatsForProfile()
        {
            IMyAPIGS myAPIGS;
            string authHeader = Values.instance.Token;

            RefitSettings refitSettings = new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            };
            myAPIGS = RestService.For<IMyAPIGS>(API_ENV.API_URL, refitSettings);

            GSPost post = new GSPost();
            GSPost result = await myAPIGS.SubmitPost(post);

            label1.Text = "Rozwiązałeś poprawnie " + result.ilosc_przerobionych_pytan + "/" + result.ilosc_wszystkich_pytan + " pytań";

            // Console.WriteLine(result.naj_wynik_z_test_teoretycznego.ilosc_punktow.ToString());

            int minutes = result.naj_wynik_z_test_teoretycznego.czas / 60;
            int seconds = result.naj_wynik_z_test_teoretycznego.czas % 60;

            label2.Text = "Największy wynik " + result.naj_wynik_z_test_teoretycznego.ilosc_punktow + "/72 pkt";

            label3.Text = "Czas najlepszego testu " + minutes + "min " + seconds + "s";
            
            
        }
        async void GenerateRanking()
        {
            IMyAPIGR myAPIGR;
            string authHeader = Values.instance.Token;
            RefitSettings refitSettings = new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            };
            myAPIGR = RestService.For<IMyAPIGR>(API_ENV.API_URL, refitSettings);
            GRPost post = new GRPost();
            GRPost result = await myAPIGR.SubmitPost(post);

            List<UserModel> users = new List<UserModel>();

            Console.WriteLine(result.ranking.Count.ToString());

            for(int i = 1; i <= result.ranking.Count; i++)
            {
                UserModel user = new UserModel(result.ranking[i - 1].login, result.ranking[i - 1].czas, i);
                users.Add(user);
            }

            // Sortuje tablicę użytkowników po ilości punktów
            List<UserModel> sorted = users.OrderByDescending(user => user.Time).ToList();

            // Zmienia miejsca w rankingu po sortowaniu
            foreach (UserModel user in sorted)
            {
                user.ChangeUserRankingPlace(sorted.IndexOf(user) + 1);
                UserRanking userRanking = new UserRanking(user);
                usersColors.Add(userRanking);
            }

            // Przekazuje posortowaną listę do front-endu
            UserRankingList.ItemsSource = usersColors;
        }
        async void KursT(object sender, EventArgs e)
        {
            KursButton.Opacity = 0.3;
            await Navigation.PushModalAsync(new Page5());
            KursButton.Opacity = 0;
        }
        async void Skrzyzowania(object sender, EventArgs e)
        {
            SkrzyzowaniaButton.Opacity = 0.3;
            await Navigation.PushModalAsync(new Page7());
            SkrzyzowaniaButton.Opacity = 0;
        }
        async void Budowa(object sender, EventArgs e)
        {
            BudowaButton.Opacity = 0.3;
            await Navigation.PushModalAsync(new Page5());
            BudowaButton.Opacity = 0;
        }
        protected override bool OnBackButtonPressed()
        {
            Navigation.PushModalAsync(new Page1());
            return true;
        }
    }
}