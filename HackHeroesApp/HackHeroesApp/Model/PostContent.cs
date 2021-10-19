using System;
using System.Collections.Generic;
using System.Text;

namespace HackHeroesApp.Model
{
    public class API_ENV
    {
        public static string API_URL = "http://192.168.0.180:5000/api/v1";
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
        public int poziom { get; set; }
    }
    public class QLPost
    {
        public List<int> pytania { get; set; }
    }
    public class Pytanie
    {
        public string numer_pytania { get; set; }
        public string pytanie { get; set; }
        public string odpowiedz_a { get; set; }
        public string odpowiedz_b { get; set; }
        public string odpowiedz_c { get; set; }
        public string poprawna_odp { get; set; }
        public string media { get; set; }
        public string zakres_struktury { get; set; }
        public string liczba_punktow { get; set; }
        public string nazwa_bloku { get; set; }
        public int id { get; set; }
    }

    public class QIDPost
    {
        public Pytanie pytanie { get; set; }
        public string pytanie_id { get; set; }
    }

    public class QCAPost
    {
        public string uzytkownik_odp { get; set; }
        public string pytanie_id { get; set; }
        public string status { get; set; }
    }

}
