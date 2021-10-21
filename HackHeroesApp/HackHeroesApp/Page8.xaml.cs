using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackHeroesApp.ValuesF;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page8 : ContentPage
    {
        public Page8()
        {
            InitializeComponent();
            generuj();
        }
        async void Back(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page7());
        }
        protected override bool OnBackButtonPressed()
        {
            Navigation.PushModalAsync(new Page7());
            return true;
        }
        string odp_poprawna = "";
        async void generuj()
        {
            switch (Crossroad.instance.crossroads)
            {
                case 1:
                    //PytanieZdj.Source = "";
                    button1.Text = "1.A 2.B 3.C 4.D";
                    button2.Text = "1.A 2.B 3.C 4.D";
                    button3.Text = "1.A 2.B 3.C 4.D";
                    button4.Text = "1.A 2.B 3.C 4.D";
                    odp_poprawna = "A";
                    break;
                case 2:
                    //PytanieZdj.Source = "";
                    button1.Text = "1.A 2.B 3.C 4.D";
                    button2.Text = "1.A 2.B 3.C 4.D";
                    button3.Text = "1.A 2.B 3.C 4.D";
                    button4.Text = "1.A 2.B 3.C 4.D";
                    odp_poprawna = "A";
                    break;

            }
        }

        private void button1_Clicked(object sender, EventArgs e)
        {

        }
        private void button2_Clicked(object sender, EventArgs e)
        {

        }
        private void button3_Clicked(object sender, EventArgs e)
        {

        }
        private void button4_Clicked(object sender, EventArgs e)
        {

        }
    }
}