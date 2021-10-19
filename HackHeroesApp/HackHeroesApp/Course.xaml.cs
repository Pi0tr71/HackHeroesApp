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
        string odp_tnabc = "";
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
            var informacje = "Punkty : " + result.pytanie.liczba_punktow + "  Nr pytania : " + result.pytanie.numer_pytania + "  Zakres : " + result.pytanie.zakres_struktury;
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
            if("A" == odp_tnabc)
            {

                button1.BackgroundColor = Color.FromHex("3c987a");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("B14157");
                
            }
            if(odp_tnabc == "B" || odp_tnabc == "T")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("3c987a");
                button3.BackgroundColor = Color.FromHex("B14157");


            }
            if (odp_tnabc == "C" || odp_tnabc == "N")
            {

                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("3c987a");


            }
        }
        private void button2_Clicked(object sender, EventArgs e)
        {
            if ("A" == odp_tnabc)
            {
                button1.BackgroundColor = Color.FromHex("3c987a");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("B14157");

            }
            if (odp_tnabc == "B" || odp_tnabc == "T")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("3c987a");
                button3.BackgroundColor = Color.FromHex("B14157");


            }
            if (odp_tnabc == "C" || odp_tnabc == "N")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("3c987a");


            }
        }

        private void button3_Clicked(object sender, EventArgs e)
        {
            if ("A" == odp_tnabc)
            {
                button1.BackgroundColor = Color.FromHex("3c987a");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("B14157");

            }
            if (odp_tnabc == "B" || odp_tnabc == "T")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("3c987a");
                button3.BackgroundColor = Color.FromHex("B14157");


            }
            if (odp_tnabc == "C" || odp_tnabc == "N")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("3c987a");


            }
        }

        private void button4_Clicked(object sender, EventArgs e)
        {
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



    }
}