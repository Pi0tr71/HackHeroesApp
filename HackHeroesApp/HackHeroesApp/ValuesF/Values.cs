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
}
