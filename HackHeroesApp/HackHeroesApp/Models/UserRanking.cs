using System;
using System.Collections.Generic;
using System.Text;

namespace HackHeroesApp.Models
{
    public class UserRanking
    {
        private UserModel user;
        private string backgroundColor;
        private string fontColor;

        public UserModel User { get { return user; } }
        public string BackgroundColor { get { return backgroundColor; } }
        public string FontColor { get { return fontColor; } }

        /// <summary>
        /// Tworzy użytkonika gotowego do wyświetlenia w rankingu i przypisuje jego wierszowi odpowiedni styl
        /// </summary>
        /// <param name="user">Obiekt użytkownika przed posortowaniem</param>
        public UserRanking(UserModel user)
        {
            this.user = user;
            this.backgroundColor = (user.RankingPlace % 2) == 0 ? "#f0f0f0" : "White";
            this.fontColor = "Black";
        }
    }
}
