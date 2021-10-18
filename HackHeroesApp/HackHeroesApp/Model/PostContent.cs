using System;
using System.Collections.Generic;
using System.Text;

namespace HackHeroesApp.Model
{
    public class API_ENV
    {
        public static string API_URL = "http://192.168.8.112:5000/api/v1";
    }

    public class RegPost
    {
        public string email { get; set; }
        public string haslo { get; set; }
        public string login { get; set; }
        public string status { get; set; }
    }
    public class LogPost
    {
        public string email { get; set; }
        public string haslo { get; set; }
        public string status { get; set; }
        public string token { get; set; }
        public int poziom { get; set; }
    }
    public class TokenPost
    {
        public string login { get; set; }
    }
}
