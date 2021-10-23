using System;
using System.Collections.Generic;
using System.Text;

namespace HackHeroesApp.Models
{
    public class UserModel
    {
        private string login;
        private int time;
        private int rankingPlace;

        public string Login { get { return login; } }
        public int Time { get { return time; } }
        public int RankingPlace { get { return rankingPlace; } }

        /// <summary>
        /// Tworzy nowego użytkownika
        /// </summary>
        /// <param name="id"></param>
        /// <param name="login"></param>
        /// <param name="email"></param>
        /// <param name="level"></param>
        /// <param name="rankingPlace"></param>
        public UserModel(string login, int time, int rankingPlace)
        {
            this.login = login;
            this.time = time;
            this.rankingPlace = rankingPlace;
        }

        /// <summary>
        /// Zmienia miejsce w rankingu dla użytkownika
        /// </summary>
        /// <param name="place">Miejsce, na które wskoczy użytkownik</param>
        public void ChangeUserRankingPlace(int place)
        {
            rankingPlace = place;
        }
    }
}
