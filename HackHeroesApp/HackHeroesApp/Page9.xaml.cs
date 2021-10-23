using HackHeroesApp.Model;
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
    public partial class Page9 : ContentPage
    {
        public Page9()
        {
            InitializeComponent();
            slajd();
        }
        int nrslajdu = 1;
        string link = "";
        string text = "";
        void slajd()
        {
            switch (nrslajdu)
            {
                case 1:
                    link = API_ENV.API_HOME + "/CAR/AUTOF.jpg";
                    text = "1.Światła mijania oraz światła drogowe \n2.Kierunkowskazy \n3.Światła postojowe/pozycyjne";
                    break;
                case 2:
                    link = API_ENV.API_HOME + "/CAR/podmasce.jpg";
                    text = "1.Zbiornik płyynu chłodzącego \n2.Wlew płynu od spryskiwaczy \n3.Wlew oleju \n4.Pomiar poziomu oleju \n5.Zbiornik płynu hamulcowego";
                    break;
                case 3:
                    link = API_ENV.API_HOME + "/CAR/AUTOL.jpg";
                    text = "1.Kierunkowskaz";
                    break;
                case 4:
                    link = API_ENV.API_HOME + "/CAR/kokpitpodpisany.jpg";
                    text = "1.Światła mijania \n2.Światła drogowe \n3.Światła przeciwmgielne przednie \n4.Światła przeciwmgielne tylne \n5.Kierunkowskaz lewy \n6.Kierunkowskaz prawy";
                    break;
                case 5:
                    link = API_ENV.API_HOME + "/CAR/AUTOB.jpg";
                    text = "1.Światła postojowe/pozycyjne \n2.Światła kierunkowskazów / awaryjne \n3.Światła hamowania(stop) \n4.Światło przeciwmgłowe tylne \n5.Światło cofania \n6.Podświetlenie tablicy rejestracyjnej";
                    break;
                case 6:
                    link = API_ENV.API_HOME + "/CAR/AUTOR.jpg";
                    text = "1.Kierunkowskaz";
                    break;
            }
            FrontImage.Source = link;
            LabelText.Text = text;
            
        }
        private void Nastepny_Clicked(object sender, EventArgs e)
        {
            if (nrslajdu >= 6)
            {
                nrslajdu = 1;
                slajd();
            }
            else
            {
                nrslajdu++;
                slajd();
            }
        }

        private void Cofnij_Clicked(object sender, EventArgs e)
        {
            if(nrslajdu <= 1)
            {
                nrslajdu = 6;
                slajd();
            }
            else
            {
                nrslajdu--;
                slajd();
            }

        }

    }
}