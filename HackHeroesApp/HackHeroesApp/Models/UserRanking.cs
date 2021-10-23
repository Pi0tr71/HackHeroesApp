using System;
using System.Collections.Generic;
using System.Text;

namespace HackHeroesApp.Models
{
    public class UserRanking
    {
        private UserModel user;
        private string convertedTime;
        private string backgroundColor;
        private string fontColor;

        public UserModel User { get { return user; } }
        public string ConvertedTime { get { return convertedTime; } }
        public string BackgroundColor { get { return backgroundColor; } }
        public string FontColor { get { return fontColor; } }

        public UserRanking(UserModel user)
        {
            this.user = user;
            this.backgroundColor = (user.RankingPlace % 2) == 0 ? "#f0f0f0" : "White";

            int minutes = user.Time / 60;
            int seconds = user.Time - (minutes * 60);

            this.convertedTime = minutes.ToString() + "min " + seconds.ToString() + "s";
            this.fontColor = "Black";
        }
    }
}
