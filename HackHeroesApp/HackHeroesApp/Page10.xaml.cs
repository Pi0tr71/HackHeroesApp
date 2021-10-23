using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page10 : ContentPage
    {
        public Page10()
        {
            InitializeComponent();
            slajd();
        }
        int nrslajdu = 1;
        string link = "";
        string text = "";
        string odpowiedz_a = "";
        string odpowiedz_b = "";
        string odpowiedz_c = "";
        string media = "";
        string pytanie = "";
        string poprawna_odp = "";

        void slajd()
        {
            switch (nrslajdu)
            {
                case 1:
                    media = "http://www.null.pila.pl/CAR/podmasce.jpg";
                    link = "http=//46.41.136.62/CAR/AUTOF.jpg";
                    odpowiedz_a = "Wlew paliwa";
                    odpowiedz_b = "Wlew płynu chłodniczego";
                    odpowiedz_c = "Wlew płynu chmulcowego";
                    poprawna_odp = "B";
                    pytanie = "Co znajduje sie pod numerem 1";
                    break;
                case 2:
                    media = "http://www.null.pila.pl/CAR/podmasce.jpg";
                    odpowiedz_a = "Wlew oleju";
                    odpowiedz_b = "Wlew płynu do spryskiwaczy";
                    odpowiedz_c = "Pomiar poziomu płyny chłodniczego";
                    poprawna_odp = "B";
                    pytanie = "Co znajduje sie pod numerem 2";
                    break;
                case 3:
                    media = "http://www.null.pila.pl/CAR/podmasce.jpg";
                    odpowiedz_a = "Wlew oleju";
                    odpowiedz_b = "Wlew płynu chłodniczego";
                    odpowiedz_c = "Wlew płynu chmulcowego";
                    poprawna_odp = "A";
                    pytanie = "Co znajduje sie pod numerem 3";
                    break;
                case 4:
                    media = "http://www.null.pila.pl/CAR/podmasce.jpg";
                    odpowiedz_a = "Bagnet do poziomu spryskiwaczy";
                    odpowiedz_b = "Bagnet do poziomu wody w silniku";
                    odpowiedz_c = "Bagnet do poziomu oleju w silniku";
                    poprawna_odp = "C";
                    pytanie = "Co znajduje sie pod numerem 4";
                    break;
                case 5:
                    media = "http://www.null.pila.pl/CAR/podmasce.jpg";
                    odpowiedz_a = "Wlew płynu chłodniczego";
                    odpowiedz_b = "Wlew płynu chmulcowego";
                    odpowiedz_c = "Bagnet do poziomu oleju w silniku";
                    poprawna_odp = "B";
                    pytanie = "Co znajduje sie pod numerem 5";
                    break;
                case 6:
                    media = "http://www.null.pila.pl/CAR/podmasce.jpg";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    odpowiedz_c = "";
                    poprawna_odp = "T";
                    pytanie = "Czy poziom płynu (numer 1) zawsze powinien być między maximum a minimum";
                    break;
                case 7:
                    media = "http://www.null.pila.pl/CAR/podmasce.jpg";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    odpowiedz_c = "";
                    poprawna_odp = "N";
                    pytanie = "Czy poziom płynu (numer 2) zawsze powinien być między maximum a minimum";
                    break;
                case 8:
                    media = "http://www.null.pila.pl/CAR/podmasce.jpg";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    odpowiedz_c = "";
                    poprawna_odp = "N";
                    pytanie = "Czy poziom płynu (numer 4) zawsze powinien być poniżej minimum";
                    break;
                case 9:
                    media = "http://www.null.pila.pl/CAR/podmasce.jpg";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    odpowiedz_c = "";
                    poprawna_odp = "N";
                    pytanie = "Czy poziom płynu (numer 5) zawsze powinien być powyżej maximum";
                    break;
                case 10:
                    media = "http://www.null.pila.pl/img/kokpitall.a9478a39.jpg";
                    odpowiedz_a = "Światła pozycyjne";
                    odpowiedz_b = "Światła drogowe";
                    odpowiedz_c = "Światła mijania";
                    poprawna_odp = "C";
                    pytanie = "Kontrolka o numerze 1 oznacza";
                    break;
                case 11:
                    media = "http://www.null.pila.pl/img/kokpitall.a9478a39.jpg";
                    odpowiedz_a = "Światła drogowe";
                    odpowiedz_b = "Światła przeciwmgielne tylnie";
                    odpowiedz_c = "Światła mijania";
                    poprawna_odp = "A";
                    pytanie = "Kontrolka o numerze 2 oznacza";
                    break;
                case 12:
                    media = "http://www.null.pila.pl/img/kokpitall.a9478a39.jpg";
                    odpowiedz_a = "Światła przeciwmgielne tylnie";
                    odpowiedz_b = "Światła drogowe";
                    odpowiedz_c = "Światła przeciwmgielne tylnie";
                    poprawna_odp = "A";
                    pytanie = "Kontrolka o numerze 4 oznacza";
                    break;
                case 13:
                    media = "http://www.null.pila.pl/img/kokpitall.a9478a39.jpg";
                    odpowiedz_a = "Kierunkowskaz w lewo";
                    odpowiedz_b = "Kierunkowskaz w prawo";
                    odpowiedz_c = "Światła awaryjne";
                    poprawna_odp = "A";
                    pytanie = "Kontrolka o numerze 5 oznacza";
                    break;
                case 14:
                    media = "http://www.null.pila.pl/img/kokpitall.a9478a39.jpg";
                    odpowiedz_a = "Kierunkowskaz w lewo";
                    odpowiedz_b = "Kierunkowskaz w prawo";
                    odpowiedz_c = "Światła awaryjne";
                    poprawna_odp = "B";
                    pytanie = "Kontrolka o numerze 6 oznacza";
                    break;
                case 15:
                    media = "http://www.null.pila.pl/img/kokpitall.a9478a39.jpg";
                    odpowiedz_a = "Check engine";
                    odpowiedz_b = "Kierunkowskaz w prawo i lewo";
                    odpowiedz_c = "Światła awaryjne";
                    poprawna_odp = "C";
                    pytanie = "Jeśli kontrolki 5 i 6 mrugają to oznacza że:";
                    break;
                case 16:
                    media = "http://www.null.pila.pl/img/kokpitall.a9478a39.jpg";
                    odpowiedz_a = "";
                    odpowiedz_b = "";
                    odpowiedz_c = "";
                    poprawna_odp = "T";
                    pytanie = "Jeśli kierunkowskaz mryga za szybko to oznacza uszkodzenie kierunkowskazu";
                    break;
            }
            if(odpowiedz_a == "")
            {
                button1.Text = "Tak";
                button2.Text = "Nie";
            }
            else
            {
                button1.Text = odpowiedz_a;
                button2.Text = odpowiedz_b;
                button3.Text = odpowiedz_c;
            }
            Zdj.Source = media;
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

        private void button4_Clicked(object sender, EventArgs e)
        {
            if(nrslajdu == 16)
            {
                nrslajdu = 1;
                button1.BackgroundColor = Color.FromHex("3c987a");
                button2.BackgroundColor = Color.FromHex("3c987a");
                button3.BackgroundColor = Color.FromHex("3c987a");
                slajd();
            }
            else
            {
                nrslajdu++;
                button1.BackgroundColor = Color.FromHex("3c987a");
                button2.BackgroundColor = Color.FromHex("3c987a");
                button3.BackgroundColor = Color.FromHex("3c987a");
                slajd();
            }
        }
    }
}