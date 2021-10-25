using System;
using System.Collections.Generic;
using System.Text;

namespace HackHeroesApp.ValuesF
{
    public class Values
    {
        public static Values instance;

        public string Token;
        public int Poziom;
        public string Login;

        public Values(string token, int poziom, string login)
        {
            this.Token = token;
            this.Poziom = poziom;
            this.Login = login;
            instance = this;
        }
    }
    public class Skrzyzowanie
    {
        public static Skrzyzowanie instance2;

        public int SkrzyzowanieP = 0;

        public Skrzyzowanie( int SkrzyzowanieP)
        {
            this.SkrzyzowanieP = SkrzyzowanieP;
            instance2 = this;
        }
    }

    public class TestWynik
    {
        public static TestWynik Cos;

        public int Pkt;

        public TestWynik(int pkt)
        {
            this.Pkt = pkt;
            Cos = this;
        }
    }
}
