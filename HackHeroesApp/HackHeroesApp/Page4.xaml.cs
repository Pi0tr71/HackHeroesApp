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

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : TabbedPage
    {

        /// <summary>
        /// Lista wszytkich użytkowników
        /// </summary>
        //private List<UserModel> users = new List<UserModel>();
        //private List<UserRanking> usersColors = new List<UserRanking>();

        public Page4()
        {
            InitializeComponent();
            int poziom = Values.Cos.Poziom;
            string login = Values.Cos.Login;
            PoziomText.Text = "Poziom : " + poziom;
            LoginText.Text = "Nick : "+login;

            //    UsersRanking();
            //}



            ///// <summary>
            ///// Zwraca posortowaną listę rankingu użytkowników
            ///// </summary>
            //private void UsersRanking()
            //{
            //    Random rnd = new Random();

            //    // Tworzy przykładowych użytkowników
            //    for (int i = 1; i <= 30; i++)
            //    {
            //        int level = rnd.Next(1, 20);
            //        users.Add(new UserModel(i, $"Nazwa{i}", $"user{i}@test.com", level, i));
            //    }

            //    // Sortuję tablicę użytkowników po ilości punktów
            //    List<UserModel> sorted = users.OrderByDescending(user => user.Level).ToList();

            //    // Zmienia miejsca w rankingu po sortowaniu
            //    foreach(UserModel user in sorted){
            //        user.ChangeUserRankingPlace(sorted.IndexOf(user));
            //        UserRanking userRanking = new UserRanking(user);
            //        usersColors.Add(userRanking);
            //    }

            //    // Przekazuje posortowaną listę do front-endu
            //    UserRankingList.ItemsSource = usersColors;
        }
        async void KursT(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page5());
        }
    }
}