using HackHeroesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RankingPage : ContentPage
    {

        /// <summary>
        /// Lista wszytkich użytkowników
        /// </summary>
        private List<UserModel> users = new List<UserModel>();

        public RankingPage()
        {
            InitializeComponent();
            UsersRanking();
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
                users.Add(new UserModel(i, $"Nazwa{i}", $"user{i}@test.com", level, i));
            }

            // Sortuję tablicę użytkowników po ilości punktów
            List<UserModel> sorted = users.OrderByDescending(user => user.Level).ToList();

            // Zmienia miejsca w rankingu po sortowaniu
            foreach (UserModel user in sorted)
            {
                user.ChangeUserRankingPlace(sorted.IndexOf(user));
            }

            // Przekazuje posortowaną listę do front-endu
            UserRankingList.ItemsSource = sorted;
        }
    }
}