using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackHeroesApp.Interface;
using HackHeroesApp.Model;
using Refit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text.RegularExpressions;
using HackHeroesApp.ValuesF;
using System.Threading;
using System.IO;

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Test : ContentPage
    {
        DateTime start;
        public Test()
        {
            InitializeComponent();
            pytania();
            start = DateTime.Now;
        }
        int dlugosclisty;
        int lppytanie = 0;
        int dlugosc4 = 0;
        List<int> pytanieid;
        string odp_u = "";
        bool buttonmaxone = true;
        string medialink = "";
        string link = "";
        string odp_tnabc = "";
        int lp_pkt = 0;
        string pop_odp = "";
        bool tn = false;
        int punkty_zdobyte = 0;
        List<string> odpowiedzi_u = new List<string>();
        List<Pytania> pytaniatablica = new List<Pytania>();


        async void pytania()
        {
            IMyAPIGT myAPIGT;
            var authHeader = Values.instance.Token;
            var refitSettings = new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            };
            myAPIGT = RestService.For<IMyAPIGT>(API_ENV.API_URL, refitSettings);
            Console.WriteLine("123");
            GTPost post = new GTPost();
            GTPost result1 = await myAPIGT.SubmitPost(post);
            dlugosclisty = result1.pytania.Count;
            Console.WriteLine(dlugosclisty);
            pytaniatablica = result1.pytania;
            Console.WriteLine("123");
            Info();
        }
        void Info()
        {
            Console.WriteLine(lppytanie);
            Console.WriteLine(pytaniatablica[lppytanie].media);
            Console.WriteLine(pytaniatablica[lppytanie].odpowiedz_a);
            Console.WriteLine(pytaniatablica[lppytanie].odpowiedz_b);
            Console.WriteLine(pytaniatablica[lppytanie].pytanie);
            var informacje = "Punkty: " + pytaniatablica[lppytanie].liczba_punktow + "  Zakres: " + pytaniatablica[lppytanie].zakres_struktury + "   " + (lppytanie + 1) + "/" + dlugosclisty;
            PZN.Text = informacje;
            PytanieText.Text = pytaniatablica[lppytanie].pytanie;
            lp_pkt = Int32.Parse(pytaniatablica[lppytanie].liczba_punktow);
            Console.WriteLine(pytaniatablica[lppytanie].poprawna_odp);
            pop_odp = pytaniatablica[lppytanie].poprawna_odp;
            Console.WriteLine("123");
            if (pytaniatablica[lppytanie].odpowiedz_a == "")
            {
                tn = true;
            }
            if (pytaniatablica[lppytanie].odpowiedz_a == "")
            {
                odp_tnabc = pytaniatablica[lppytanie].poprawna_odp;
                button1.IsEnabled = false;
                button2.IsEnabled = true;
                button3.IsEnabled = true;
                button1.Opacity = 0;
                button2.Text = "Tak";
                button2.FontSize = 30;
                button3.Text = "Nie";
                button3.FontSize = 30;
            }
            if (pytaniatablica[lppytanie].odpowiedz_a != "")
            {
                odp_tnabc = pytaniatablica[lppytanie].poprawna_odp;
                button1.IsEnabled = true;
                button2.IsEnabled = true;
                button3.IsEnabled = true;
                button1.Opacity = 1;
                button1.Text = pytaniatablica[lppytanie].odpowiedz_a;
                button1.FontSize = 20;
                button2.Text = pytaniatablica[lppytanie].odpowiedz_b;
                button2.FontSize = 20;
                button3.Text = pytaniatablica[lppytanie].odpowiedz_c;
                button3.FontSize = 20;
            }
            if (pytaniatablica[lppytanie].media == "")
            {
                PytaniaFilm.IsVisible = false;
                PytanieZdj.IsVisible = true;
                PytanieZdj.Source = "bz.png";
            }
            else
            {
                dlugosc4 = pytaniatablica[lppytanie].media.Length;
                Console.WriteLine("Długość " + dlugosc4);
                medialink = pytaniatablica[lppytanie].media;
                link = API_ENV.API_MEDIA + pytaniatablica[lppytanie].media;
                Console.WriteLine(link);
                wstaw(link);
                Console.WriteLine("123");
            }

            void wstaw(string link)
            {
                string extension = Path.GetExtension(link);

                if (extension == ".mp4")
                {
                    PytaniaFilm.Source = link;
                    PytanieZdj.IsVisible = false;
                    PytaniaFilm.IsVisible = true;
                }
                else
                {
                    PytanieZdj.Source = link;
                    PytaniaFilm.IsVisible = false;
                    PytanieZdj.IsVisible = true;
                }
            }
        }
        async void wynik()
        {
            IMyAPIIS myAPIIS;

            DateTime end = DateTime.Now;
            TimeSpan finalTime = end.Subtract(start);
            var v = new TestWynik(punkty_zdobyte, finalTime);

            var authHeader = Values.instance.Token;
            var refitSettings = new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            };
            myAPIIS = RestService.For<IMyAPIIS>(API_ENV.API_URL, refitSettings);
            ISPost post = new ISPost();
            //post.ilosc_punktow = "72";
            //post.sekund = "1200";
            post.ilosc_punktow = punkty_zdobyte.ToString();
            post.sekund = finalTime.Seconds.ToString();
            ISPost result = await myAPIIS.SubmitPost(post);
            await Navigation.PushModalAsync(new TestOdp());
        }
        private void button1_Clicked(object sender, EventArgs e)
        {
            if (tn)
            {
                odp_u = "T";
            }
            else
            {
                odp_u = "A";
            }
            button1.BackgroundColor = Color.FromHex("2a6b56");
            button2.BackgroundColor = Color.FromHex("3c987a");
            button3.BackgroundColor = Color.FromHex("3c987a");


        }
        private void button2_Clicked(object sender, EventArgs e)
        {
            if (tn)
            {
                odp_u = "N";
            }
            else
            {
                odp_u = "B";
            }
            button1.BackgroundColor = Color.FromHex("3c987a");
            button2.BackgroundColor = Color.FromHex("2a6b56");
            button3.BackgroundColor = Color.FromHex("3c987a");
        }

        private void button3_Clicked(object sender, EventArgs e)
        {
            odp_u = "C";
            button1.BackgroundColor = Color.FromHex("3c987a");
            button2.BackgroundColor = Color.FromHex("3c987a");
            button3.BackgroundColor = Color.FromHex("2a6b56");
        }

        private async void button4_Clicked(object sender, EventArgs e)
        {
            button1.BackgroundColor = Color.FromHex("3c987a");
            button2.BackgroundColor = Color.FromHex("3c987a");
            button3.BackgroundColor = Color.FromHex("3c987a");
            if (lppytanie >= (dlugosclisty - 1))
            {
                Console.WriteLine("dziala?");
                if (odp_u == pop_odp)
                {
                    Console.WriteLine("1dasdsada23");
                    punkty_zdobyte += lp_pkt;
                }
                odpowiedzi_u.Add(odp_u);
                wynik();
            }
            else
            {
                if (odp_u == pop_odp)
                {
                    Console.WriteLine("1dasdsada23");
                    punkty_zdobyte += lp_pkt;
                }
                Console.WriteLine("dasdaadasd");
                odpowiedzi_u.Add(odp_u);
                odp_u = "brak";
                lppytanie++;
                Console.WriteLine("dasdaadasd");
                Info();
            }

        }
        protected override bool OnBackButtonPressed()
        {
            Navigation.PushModalAsync(new Page5());
            return true;
        }

    }
}