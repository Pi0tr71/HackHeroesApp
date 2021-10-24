using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HackHeroesApp.ValuesF;

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page8 : ContentPage
    {
        int slideID;

        string odpowiedz_a = "";
        string odpowiedz_b = "";
        string odpowiedz_c = "";
        string media = "";
        string pytanie = "";
        string poprawna_odp = "";

        public Page8(int slideID)
        {
            InitializeComponent();
            this.slideID = slideID;
            slajd();
        }

        void slajd()
        {
            switch (slideID)
            {
                case 1:
                    media = "a1";
                    odpowiedz_a = "2, 1";
                    odpowiedz_b = "1, 2";
                    poprawna_odp = "A";
                    pytanie = "Poprawna kolejność przejazdu przez skrzyżowanie to:";
                    break;
                case 2:
                    media = "a1";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    odpowiedz_c = "";
                    poprawna_odp = "T";
                    pytanie = "Czy auto z numerem 1 ma pierwszeństwo przejazdu?";
                    break;
                case 3:
                    media = "a2";
                    odpowiedz_a = "1, 2, 3";
                    odpowiedz_b = "3, 2, 1";
                    odpowiedz_c = "2, 3, 1";
                    poprawna_odp = "C";
                    pytanie = "Poprawna kolejność przejazdu przez skrzyżowanie to:";
                    break;
                case 4:
                    media = "a2";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    poprawna_odp = "N";
                    pytanie = "Czy auto z numerem 1 ma pierwszeństwo przejazdu?";
                    break;
                case 5:
                    media = "a3";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    poprawna_odp = "N";
                    pytanie = "Czy auto z numerem 1 ma pierwszeństwo przejazdu?";
                    break;
                case 6:
                    media = "a3";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    poprawna_odp = "T";
                    pytanie = "Czy auto z numerem 3 ma pierwszeństwo przejazdu?";
                    break;
                case 7:
                    media = "a4";
                    odpowiedz_a = "1";
                    odpowiedz_b = "2";
                    odpowiedz_c = "3";
                    poprawna_odp = "C";
                    pytanie = "Które auto ma pierwszeństwo przejzadu?";
                    break;;
                case 8:
                    media = "a4";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    poprawna_odp = "N";
                    pytanie = "Czy auto z numerem 2 ma pierwszeństwo przejazdu?";
                    break;
                case 9:
                    media = "a5";
                    odpowiedz_a = "2";
                    odpowiedz_b = "1";
                    poprawna_odp = "B";
                    pytanie = "Które auto ma pierwszeństwo przejazdu?";
                    break;
                case 10:
                    media = "a5";
                    odpowiedz_a = "2";
                    odpowiedz_b = "3";
                    poprawna_odp = "A";
                    pytanie = "Które auto pojedzie jako pierwsze?";
                    break;
                case 11:
                    media = "a6";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    poprawna_odp = "T";
                    pytanie = "Czy auto z numerem 1 może wjechać na skrzyżowanie?";
                    break;
                case 12:
                    media = "a7";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    poprawna_odp = "T";
                    pytanie = "Czy auto z numerem 2 ma pierwszeństwo przejazdu?";
                    break;
                case 13:
                    media = "a7";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    poprawna_odp = "N";
                    pytanie = "Czy auto z numerem 1 ma pierwszeństwo przejazdu?";
                    break;
                case 14:
                    media = "a8";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    poprawna_odp = "T";
                    pytanie = "Czy auto z numerem 2 ma pierwszeństwo przejazdu?";
                    break;
                case 15:
                    media = "a8";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    poprawna_odp = "T";
                    pytanie = "Czy auto z numerem 1 ma pierwszeństwo przejazdu?";
                    break;
                case 16:
                    media = "a9";
                    odpowiedz_a = "1";
                    odpowiedz_b = "2";
                    odpowiedz_c = "3";
                    poprawna_odp = "B";
                    pytanie = "Kto ma pierwszeństwo przejazdu?";
                    break;
                case 17:
                    media = "a9";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    poprawna_odp = "N";
                    pytanie ="Czy auto z numerem 1 ma pierwszeństwo przejazdu przed tramwajem?";
                    break;
                case 18:
                    media = "a10";
                    odpowiedz_a = "1";
                    odpowiedz_b = "2";
                    odpowiedz_c = "3";
                    poprawna_odp = "C";
                    pytanie = "Kto ma pierwszeństwo przejazdu?";
                    break;
               case 19:
                    media = "a10";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    poprawna_odp = "N";
                    pytanie ="Czy auto z numerem 2 ma pierwszeństwo przejazdu przed tramwajem?";
                    break;
                case 20:
                    media= "a10";
                    odpowiedz_a= "";
                    odpowiedz_b = "";
                    odpowiedz_c = "";
                    poprawna_odp = "N";
                    pytanie ="Czy auto z numerem 1 ma pierwszeństwo przejazdu przed tramwajem?";
                    break;
            }
            if (odpowiedz_c == "")
            {
                button3.Opacity = 0;
                if (odpowiedz_a=="")
                {
                    button1.Text = "Tak";
                    button2.Text = "Nie";
                }
                else
                {
                    button1.Text = odpowiedz_a;
                    button2.Text = odpowiedz_b;
                }
            }
            else
            {
                button1.Text = odpowiedz_a;
                button2.Text = odpowiedz_b;
                button3.Text = odpowiedz_c;
            }

            Console.WriteLine(media +".png");
            Zdj.Source = media+".png";
            PytanieText.Text = pytanie;
        }

        private void button1_Clicked(object sender, EventArgs e)
        {
            if ("A" == poprawna_odp)
            {
                button1.BackgroundColor = Color.FromHex("18d698");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("B14157");
            }
            if (poprawna_odp == "B" || poprawna_odp == "T")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("18d698");
                button3.BackgroundColor = Color.FromHex("B14157");
            }
            if (poprawna_odp == "C" || poprawna_odp == "N")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("18d698");
            }
        }
        private void button2_Clicked(object sender, EventArgs e)
        {
            if ("A" == poprawna_odp)
            {
                button1.BackgroundColor = Color.FromHex("18d698");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("B14157");
            }
            if (poprawna_odp == "B" || poprawna_odp == "T")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("18d698");
                button3.BackgroundColor = Color.FromHex("B14157");
            }
            if (poprawna_odp == "C" || poprawna_odp == "N")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("18d698");
            }
        }

        private void button3_Clicked(object sender, EventArgs e)
        {
            if ("A" == poprawna_odp)
            {
                button1.BackgroundColor = Color.FromHex("18d698");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("B14157");
            }
            if (poprawna_odp == "B" || poprawna_odp == "T")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("18d698");
                button3.BackgroundColor = Color.FromHex("B14157");
            }
            if (poprawna_odp == "C" || poprawna_odp == "N")
            {
                button1.BackgroundColor = Color.FromHex("B14157");
                button2.BackgroundColor = Color.FromHex("B14157");
                button3.BackgroundColor = Color.FromHex("18d698");
            }
        }

        private async void GoToNextSlide()
        {
            slideID++;

            if(slideID > Values.Cos.Poziom)
            {
                await Navigation.PushModalAsync(new Page7());
            }

            slajd();
        }
    }
}