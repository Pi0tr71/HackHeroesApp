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
using System.Reflection;

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : TabbedPage
    {

        private List<UserModel> users = new List<UserModel>();
        private List<UserRanking> usersColors = new List<UserRanking>();

        public Page4()
        {
            InitializeComponent();
            PoziomText.Text = "Poziom " + Values.instance.Poziom; 
            LoginText.Text = Values.instance.Login;

            avatar.Source = "p" + Values.instance.Poziom + ".png";

            Console.WriteLine("Avatar: " + avatar.Source);



            staty();
            ranking();
        }

        async void staty()
        {
            IMyAPIGS myAPIGS;
            var authHeader = Values.instance.Token;
            var refitSettings = new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            };
            myAPIGS = RestService.For<IMyAPIGS>(API_ENV.API_URL, refitSettings);
            GSPost post = new GSPost();
            GSPost result = await myAPIGS.SubmitPost(post);

            int done = result.ilosc_przerobionych_pytan;
            int all = result.ilosc_wszystkich_pytan;

            label1.Text = "Rozwiązałeś poprawnie " + done + "/" + all + " pytań";
            //string nwzt = result.naj_wynik_z_test_teoretycznego.;

            if (result.status == "brak")
            {
                label2.Text = "Nie zrobiono testu teoretycznego";
                label3.Text = "Nie zrobiono testu teoretycznego";
            }
            else
            {
                NajWynikZTestTeoretycznego best = result.naj_wynik_z_test_teoretycznego;
                int minutes = best.czas / 60;
                int seconds = best.czas - (minutes * 60);
                label2.Text = "Największy wynik " + best.ilosc_punktow + "/72 pkt";
                label3.Text = "Czas najlepszego testu " + minutes + "min " + seconds + "s";
            }

            percent.Text = Math.Round((double)done / (double)all * 100D, 2).ToString() + "%";

            progressBar.Progress = (double)done / (double)all;
            progressBar.ProgressColor = Color.White;
        }

        private void StopDraging(object sender, ValueChangedEventArgs e)
        {
            return;
        }

        async void ranking()
        {
            IMyAPIGR myAPIGR;
            var authHeader = Values.instance.Token;
            var refitSettings = new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            };
            myAPIGR = RestService.For<IMyAPIGR>(API_ENV.API_URL, refitSettings);
            GRPost post = new GRPost();
            GRPost result = await myAPIGR.SubmitPost(post);

            // Sortuję tablicę użytkowników po ilości punktów
            List<Ranking> sorted = result.ranking.OrderBy(user => user.czas).ToList();

            foreach (Ranking user in sorted)
            {
                UserRanking userRanking = new UserRanking(new UserModel(user.login, user.czas, sorted.IndexOf(user) + 1));
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
            await Navigation.PushModalAsync(new Page9());
            BudowaButton.Opacity = 0;
        }
        protected override bool OnBackButtonPressed()
        {
            Navigation.PushModalAsync(new Page1());
            return true;
        }
        async void Teoretyczny(object sender, EventArgs e)
        {
            TeoretycznyButton.Opacity = 0.3;
            await Navigation.PushModalAsync(new Test());
            TeoretycznyButton.Opacity = 0;
        }
        async void Praktyczny(object sender, EventArgs e)
        {
            PraktycznyButton.Opacity = 0.3;
            await Navigation.PushModalAsync(new Page10());
            PraktycznyButton.Opacity = 0;
        }
    }
}