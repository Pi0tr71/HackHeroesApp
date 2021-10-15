using System;
using System.Collections.Generic;
using System.Text;

namespace HackHeroesApp.Model
{
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
}
