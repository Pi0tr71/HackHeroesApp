﻿using HackHeroesApp.Models;
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

        private List<UserModel> users = new List<UserModel>();
        private List<UserRanking> usersColors = new List<UserRanking>();

        public Page4()
        {
            InitializeComponent();
            PoziomText.Text = "Poziom " + Values.Cos.Poziom; 
            LoginText.Text = Values.Cos.Login;
            staty();
            ranking();
        }

        async void staty()
        {
            IMyAPIGS myAPIGS;
            var authHeader = Values.Cos.Token;
            var refitSettings = new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            };
            myAPIGS = RestService.For<IMyAPIGS>(API_ENV.API_URL, refitSettings);
            GSPost post = new GSPost();
            GSPost result = await myAPIGS.SubmitPost(post);
            label1.Text = "Rozwiązałeś poprawnie "+result.ilosc_przerobionych_pytan+"/"+result.ilosc_wszystkich_pytan+" pytań";
            int minuty = result.naj_wynik_z_test_teoretycznego.czas / 60;
            int sekundy = result.naj_wynik_z_test_teoretycznego.czas % 60;
            label2.Text = "Największy wynik "+ result.naj_wynik_z_test_teoretycznego.ilosc_punktow + "/72 pkt";
            label3.Text = "Czas najlepszego testu " + minuty + "min " + sekundy+"s";

            //slider.Minimum = 0;
            //slider.Maximum = result.ilosc_wszystkich_pytan;

            //slider.Value = result.ilosc_przerobionych_pytan;
            //slider.ValueChanged += StopDraging;

            //percent.Text = (result.ilosc_przerobionych_pytan / result.ilosc_wszystkich_pytan * 100).ToString() + "%";
        }

        private void StopDraging(object sender, ValueChangedEventArgs e)
        {
            return;
        }

        async void ranking()
        {
            IMyAPIGR myAPIGR;
            var authHeader = Values.Cos.Token;
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