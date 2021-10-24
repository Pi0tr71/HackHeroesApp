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
using HackHeroesApp.Helpers;
using System.IO;
using Xamarin.CommunityToolkit.UI.Views;

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page6 : ContentPage
    {
        int pytanieid = 1;
        int maxid = 0;
        string odp_tnabc = "";

        TimerExtended timer;

        int dlugosclisty = 0;
        int lppytanie = 0;
        string odp_u = "";
        bool buttonmaxone = true;


        string medialink = "";
        int dlugosc4 = 0;
        string link = "";

        public Page6()
        {
            InitializeComponent();
            zapytanie();

            maxid = Values.Cos.Poziom;
            maxid = Values.Cos.Poziom == 20 ? 2200 : 2000;
        }

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
            post.pytanie_id = pytanieid.ToString();
            QIDPost result = await myAPIQID.SubmitPost(post);
            var informacje = "Punkty: " + result.pytanie.liczba_punktow + "  Nr pytania: " + result.pytanie.numer_pytania + "  Zakres: " + result.pytanie.zakres_struktury + "   " +pytanieid+ "/" +maxid;
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
                    PytanieFilm.Source = link;
                    PytanieZdj.IsVisible = false;
                    PytanieFilm.IsVisible = true;
                }
                else
                {
                    PytanieZdj.Source = link;
                    PytanieFilm.IsVisible = false;
                    PytanieZdj.IsVisible = true;
                }
            }

            PZN.Text = informacje;
            PytanieText.Text = result.pytanie.pytanie;
            Console.WriteLine(result.pytanie.id);
            Console.WriteLine(result.pytanie.poprawna_odp);

            button1.IsEnabled = result.pytanie.odpowiedz_a == "" ? false : true;
            odp_tnabc = result.pytanie.poprawna_odp;
            button2.IsEnabled = true;
            button3.IsEnabled = true;

            if (result.pytanie.odpowiedz_a == "")
            {
                button1.Opacity = 0;
                button2.Text = "Tak";
                button2.FontSize = 30;
                button3.Text = "Nie";
                button3.FontSize = 30;
            }
            else
            {
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
            }
            if (odp_tnabc == "B" || odp_tnabc == "T")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("18d698");
                button3.BackgroundColor = Color.FromHex("B14157");
            }
            if (odp_tnabc == "C" || odp_tnabc == "N")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("18d698");
            }
        }
        private void button2_Clicked(object sender, EventArgs e)
        {
            if ("A" == odp_tnabc)
            {
                button1.BackgroundColor = Color.FromHex("18d698");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("B14157");
            }
            if (odp_tnabc == "B" || odp_tnabc == "T")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("18d698");
                button3.BackgroundColor = Color.FromHex("B14157");
            }
            if (odp_tnabc == "C" || odp_tnabc == "N")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("18d698");
            }
        }

        private void button3_Clicked(object sender, EventArgs e)
        {
            if ("A" == odp_tnabc)
            {
                button1.BackgroundColor = Color.FromHex("18d698");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("B14157");
            }
            if (odp_tnabc == "B" || odp_tnabc == "T")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("18d698");
                button3.BackgroundColor = Color.FromHex("B14157");
            }
            if (odp_tnabc == "C" || odp_tnabc == "N")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("18d698");
            }
        }

        private async void button4_Clicked(object sender, EventArgs e)
        {
            button1.BackgroundColor = Color.FromHex("3c987a");
            button2.BackgroundColor = Color.FromHex("3c987a");
            button3.BackgroundColor = Color.FromHex("3c987a");

            ChangeQuestion();
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushModalAsync(new Page5());
            return true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            pytanieid = Int32.Parse(idpytania.Text);
            zapytanie();
        }

        private void ChangeQuestion()
        {
            if (pytanieid >= maxid) pytanieid = 0;
            else pytanieid++;

            zapytanie();
        }
    }
}