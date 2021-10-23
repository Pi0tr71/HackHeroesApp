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
    public partial class Course : ContentPage
    {
        public Course()
        {
            InitializeComponent();
            pytania();
        }
        int dlugosclisty = 0;
        int lppytanie = 0;
        List<int> pytanieid;
        string odp_u = "";
        bool buttonmaxone = true;

        async void poprawna()
        {
            if (odp_tnabc == odp_u)
            {
                IMyAPIQCA myAPIQCA;
                var authHeader = Values.Cos.Token;
                var refitSettings = new RefitSettings()
                {
                    AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
                };
                myAPIQCA = RestService.For<IMyAPIQCA>(API_ENV.API_URL, refitSettings);
                QCAPost post = new QCAPost();
                post.pytanie_id = pytanieid[lppytanie].ToString();
                post.uzytkownik_odp = odp_tnabc;
                QCAPost result = await myAPIQCA.SubmitPost(post);
                Console.WriteLine(result.status);
                if (result.status == "lvl up")
                {
                    await DisplayActionSheet("Level up", "Ok", null, "Ukończyłeś ten poziom pytań!", "Teraz możesz przejść do kolejnego");
                    IMyAPIToken myAPIT;

                    var authHeader2 = Values.Cos.Token;
                    var refitSettings2 = new RefitSettings()
                    {
                        AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader2)
                    };
                    Console.WriteLine(refitSettings2.ToString());
                    myAPIT = RestService.For<IMyAPIToken>(API_ENV.API_URL, refitSettings2);
                    TokenPost post1 = new TokenPost();
                    TokenPost result1 = await myAPIT.SubmitPost(post1);
                    Console.WriteLine(result1.login);
                    var a = new Values(Values.Cos.Token, result1.poziom, result1.login);

                    await Navigation.PushModalAsync(new Page5());
                }
            }
        }

        async void pytania()
        {
            IMyAPIQL myAPIQL;
            var authHeader = Values.Cos.Token;
            var refitSettings = new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            };
            myAPIQL = RestService.For<IMyAPIQL>(API_ENV.API_URL, refitSettings);
            QLPost post = new QLPost();
            QLPost result1 = await myAPIQL.SubmitPost(post);
            dlugosclisty = result1.pytania.Count;
            Console.WriteLine(dlugosclisty);
            pytanieid = result1.pytania;
            zapytanie();
        }

        string medialink = "";
        int dlugosc4 = 0;
        string odp_tnabc = "";
        string link = "";

        async void zapytanie()
        {
            IMyAPIQID myAPIQID;
            var authHeader = Values.Cos.Token;
            var refitSettings = new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            };
            myAPIQID = RestService.For<IMyAPIQID>(API_ENV.API_URL, refitSettings);
            QIDPost post = new QIDPost();
            post.pytanie_id = pytanieid[lppytanie].ToString();
            QIDPost result = await myAPIQID.SubmitPost(post);
            var informacje = "Punkty: " + result.pytanie.liczba_punktow + "  Nr pytania: " + result.pytanie.numer_pytania + "  Zakres: " + result.pytanie.zakres_struktury + "   " + (lppytanie + 1) + "/" + dlugosclisty;
            if (result.pytanie.media == "")
            {
                PytanieFilm.Source = "bz.png";
            }
            else
            {
                dlugosc4 = result.pytanie.media.Length;
                Console.WriteLine("Długość " + dlugosc4);
                medialink = result.pytanie.media;
                link = API_ENV.API_MEDIA + result.pytanie.media;
                Console.WriteLine(link);
                wstaw(link);
            }
            void wstaw(string link)
            {
                string extension = Path.GetExtension(link);

                if (extension == ".mp4")
                {
                    //PytanieZdj.HeightRequest = 0;
                    PytanieFilm.Source = link;
                    Console.WriteLine("Wysokość filmu: " + PytanieFilm.VideoHeight);
                    //PytanieFilm.MinimumHeightRequest = PytanieFilm.VideoHeight * 2;
                }
                else
                {
                    //PytanieFilm.HeightRequest = 0;
                    PytanieZdj.Source = link;
                }
            }

            PZN.Text = informacje;
            PytanieText.Text = result.pytanie.pytanie;
            Console.WriteLine(result.pytanie.id);
            Console.WriteLine(result.pytanie.poprawna_odp);
            if (result.pytanie.odpowiedz_a == "")
            {
                odp_tnabc = result.pytanie.poprawna_odp;
                button1.IsEnabled = false;
                button2.IsEnabled = true;
                button3.IsEnabled = true;
                button1.Opacity = 0;
                button2.Text = "Tak";
                button2.FontSize = 30;
                button3.Text = "Nie";
                button3.FontSize = 30;
            }
            if (result.pytanie.odpowiedz_a != "")
            {
                odp_tnabc = result.pytanie.poprawna_odp;
                button1.IsEnabled = true;
                button2.IsEnabled = true;
                button3.IsEnabled = true;
                button1.Opacity = 1;
                button1.Text = result.pytanie.odpowiedz_a;
                button1.FontSize = 20;
                button2.Text = result.pytanie.odpowiedz_b;
                button2.FontSize = 20;
                button3.Text = result.pytanie.odpowiedz_c;
                button3.FontSize = 20;
            }
        }
        private void button1_Clicked(object sender, EventArgs e)
        {
            if ("A" == odp_tnabc)
            {
                button1.BackgroundColor = Color.FromHex("18d698");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("B14157");
                if (buttonmaxone)
                {
                    odp_u = odp_tnabc;
                }
                buttonmaxone = false;
            }
            if (odp_tnabc == "B" || odp_tnabc == "T")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("18d698");
                button3.BackgroundColor = Color.FromHex("B14157");
                if (buttonmaxone)
                {
                    odp_u = "B";
                }
                buttonmaxone = false;
            }
            if (odp_tnabc == "C" || odp_tnabc == "N")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("18d698");
                if (buttonmaxone)
                {
                    odp_u = "C";
                }
                buttonmaxone = false;
            }
        }
        private void button2_Clicked(object sender, EventArgs e)
        {
            if ("A" == odp_tnabc)
            {
                button1.BackgroundColor = Color.FromHex("18d698");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("B14157");
                if (buttonmaxone)
                {
                    odp_u = "A";
                }
                buttonmaxone = false;
            }
            if (odp_tnabc == "B" || odp_tnabc == "T")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("18d698");
                button3.BackgroundColor = Color.FromHex("B14157");
                if (buttonmaxone)
                {
                    odp_u = odp_tnabc;
                }
                buttonmaxone = false;
            }
            if (odp_tnabc == "C" || odp_tnabc == "N")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("18d698");
                if (buttonmaxone)
                {
                    odp_u = "C";
                }
                buttonmaxone = false;
            }
        }

        private void button3_Clicked(object sender, EventArgs e)
        {
            if ("A" == odp_tnabc)
            {
                button1.BackgroundColor = Color.FromHex("18d698");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("B14157");
                if (buttonmaxone)
                {
                    odp_u = "A";
                }
                buttonmaxone = false;
            }
            if (odp_tnabc == "B" || odp_tnabc == "T")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("18d698");
                button3.BackgroundColor = Color.FromHex("B14157");
                if (buttonmaxone)
                {
                    odp_u = "B";
                }
                buttonmaxone = false;
            }
            if (odp_tnabc == "C" || odp_tnabc == "N")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("18d698");
                if (buttonmaxone)
                {
                    odp_u = odp_tnabc;
                }
                buttonmaxone = false;
            }
        }

        private async void button4_Clicked(object sender, EventArgs e)
        {
            poprawna();
            odp_u = "";
            buttonmaxone = true;
            lppytanie++;
            button1.BackgroundColor = Color.FromHex("3c987a");
            button2.BackgroundColor = Color.FromHex("3c987a");
            button3.BackgroundColor = Color.FromHex("3c987a");
            if (lppytanie == dlugosclisty)
            {
                lppytanie = 0;
                pytania();
            }
            else
            {
                zapytanie();
            }

        }
        private void button5_Clicked(object sender, EventArgs e)
        {
            odp_u = "";
            buttonmaxone = true;
            lppytanie++;
            button1.BackgroundColor = Color.FromHex("3c987a");
            button2.BackgroundColor = Color.FromHex("3c987a");
            button3.BackgroundColor = Color.FromHex("3c987a");
            if (lppytanie == dlugosclisty)
            {
                lppytanie = 0;
                pytania();
            }
            else
            {
                zapytanie();
            }
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushModalAsync(new Page5());
            return true;
        }

    }
}