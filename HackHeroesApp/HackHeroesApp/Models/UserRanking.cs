using System;
using System.Collections.Generic;
using System.Text;

namespace HackHeroesApp.Models
{
    public class UserRanking
    {
        private UserModel user;
        private String backgroundColor;
        private String fontColor;

        public UserModel User { get { return user; } }
        public String BackgroundColor { get { return backgroundColor; } }
        public String FontColor { get { return fontColor; } }

        public UserRanking(UserModel user)
        {
            this.user = user;
            this.backgroundColor = (user.RankingPlace % 2) == 0 ? "#f0f0f0" : "White";
            // this.fontColor = (user.RankingPlace % 2) == 0 ? "White" : "Black";
            this.fontColor = "Black";
        }
    }
}
