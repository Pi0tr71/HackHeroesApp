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
    public partial class TestOdp : ContentPage
    {
        TestWynik wynik = TestWynik.instance;


        public TestOdp()
        {
            InitializeComponent();

            if (wynik.Pkt >= 68)
            {
                title.Text = "Gratulacje!";
                title.TextColor = Color.Green;
            }
            else
            {
                title.Text = "Próbuj ponownie!";
                title.TextColor = Color.Red;
            }

            points.Text = "Zdobyłeś " + wynik.Pkt + "/72";

            int minutes = wynik.getSeconds() / 60;
            int seconds = wynik.getSeconds() % 60;

            time.Text = "W czasie " + minutes + " minut i " + seconds + "sekund";
        }

        async void Back(object sender, EventArgs e)
        {
            BackButton.Opacity = 0.3;
            await Navigation.PushModalAsync(new Page4());
            BackButton.Opacity = 0;
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushModalAsync(new Page4());
            return true;
        }
    }
}