using System;
using System.Collections.Generic;
using System.Text;

namespace HackHeroesApp.ValuesF
{
    public class Values
    {
        public static Values Cos;

        public string Token;
        public int Poziom;
        public string Login;

        public Values(string token, int poziom, string login)
        {
            this.Token = token;
            this.Poziom = poziom;
            this.Login = login;
            Cos = this;
        }
    }
    public class Skrzyzowanie
    {
        public static Skrzyzowanie Cos2;

        public int SkrzyzowanieP = 0;

        public Skrzyzowanie( int SkrzyzowanieP)
        {
            this.SkrzyzowanieP = SkrzyzowanieP;
            Cos2 = this;
        }
    }
}
