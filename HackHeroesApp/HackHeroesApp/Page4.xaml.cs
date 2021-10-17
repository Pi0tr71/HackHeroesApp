using HackHeroesApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : TabbedPage
    {
        /// <summary>
        /// Lista wszytkich użytkowników
        /// </summary>
        private List<UserModel> users = new List<UserModel>();

        public Page4()
        {
            InitializeComponent();

            var imageSource1 = new UriImageSource { Uri = new Uri("https://upload.wikimedia.org/wikipedia/commons/8/81/Polski_Fiat_126p_rocznik_1973.jpg") };
            image1.Source = imageSource1;
            this.BindingContext = this;   
            
            var imageSource2 = new UriImageSource { Uri = new Uri("https://cdn.w600.comps.canstockphoto.pl/prosty-stickman-cz%C5%82owiek-klipart-wektorowy_csp43585411.jpg") };
            image2.Source = imageSource2;
            this.BindingContext = this;
           
            UsersRanking();
        }

        async void KursT(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page5());
        }

        /// <summary>
        /// Zwraca posortowaną listę rankingu użytkowników
        /// </summary>
        private void UsersRanking()
        {
            Random rnd = new Random();

            // Tworzy przykładowych użytkowników
            for (int i = 1; i <= 30; i++)
            {
                int level = rnd.Next(1, 20);
                users.Add(new UserModel(i, $"Nazwa{i}", $"user{i}@test.com",  level, i));
            }

            // Sortuję tablicę użytkowników po ilości punktów
            List<UserModel> sorted = users.OrderByDescending(user => user.Level).ToList();

            // Zmienia miejsca w rankingu po sortowaniu
            foreach(UserModel user in sorted){
                user.ChangeUserRankingPlace(sorted.IndexOf(user));
            }

            // Przekazuje posortowaną listę do front-endu
            UserRankingList.ItemsSource = sorted;
        }
    }
}