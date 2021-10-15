using System;
using System.Collections.Generic;
using System.Text;

namespace HackHeroesApp.Models
{
    public class UserModel
    {
        private int id;
        private string login;
        private string email;
        private int level;
        private int rankingPlace;

        public int ID { get { return id; } }
        public string Login { get { return login; } }
        public string Email { get { return email; } }
        public int Level { get { return level; } }
        public int RankingPlace { get { return rankingPlace; } }

        /// <summary>
        /// Tworzy nowego użytkownika
        /// </summary>
        /// <param name="id"></param>
        /// <param name="login"></param>
        /// <param name="email"></param>
        /// <param name="level"></param>
        /// <param name="rankingPlace"></param>
        public UserModel(int id, string login, string email, int level, int rankingPlace)
        {
            this.id = id;
            this.login = login;
            this.email = email;
            this.level = level;
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
