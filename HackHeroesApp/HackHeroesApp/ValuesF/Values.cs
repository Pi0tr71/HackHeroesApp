using System;
using System.Collections.Generic;
using System.Text;

namespace HackHeroesApp.ValuesF
{
    /// <summary>
    /// Obiekt przechowujący dane dostępu
    /// </summary>
    public class Values
    {
        public static Values instance;

        public string Token;
        public int Level;
        public string Login;

        /// <summary>
        /// Przypisuje wartości do ogólnodostępnych dla aplikacji danych o użytkowniku i jego dostępie do API
        /// </summary>
        /// <param name="token">Token dostępu do API</param>
        /// <param name="level">Poziom użytkownika</param>
        /// <param name="login">Login użytkownika</param>
        public Values(string token, int level, string login)
        {
            this.Token = token;
            this.Level = level;
            this.Login = login;
            instance = this;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Crossroad
    {
        public static Crossroad instance;

        public int crossroads = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="crossroads"></param>
        public Crossroad(int crossroads)
        {
            this.crossroads = crossroads;
            instance = this;
        }
    }
}
