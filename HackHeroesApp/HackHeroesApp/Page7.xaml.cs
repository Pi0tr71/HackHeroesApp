using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HackHeroesApp.ValuesF;
using HackHeroesApp.Model;

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page7 : ContentPage
    {
        List<Button> buttons = new List<Button>();

        public Page7()
        {
            InitializeComponent();

            foreach (var instance in Container.Children)
            {
                if (instance.GetType() == typeof(Button))
                {
                    buttons.Add((Button)instance);
                }
            }

            for (int i = 0; i < buttons.Count; i++)
            {
                if (i < Values.Cos.Poziom) buttons[i].BackgroundColor = Color.FromHex("18d698");
                else buttons[i].BackgroundColor = Color.FromHex("B14157");
            }
        }
        async void Back(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page4());
        }
        protected override bool OnBackButtonPressed()
        {
            Navigation.PushModalAsync(new Page4());
            return true;
        }
        int poziomtutaj = Values.Cos.Poziom;
        private void b1_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 1)
            {
                var a = new Skrzyzowanie(1);
                Navigation.PushModalAsync(new Page8());
            }
            
        }
        private void b2_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 2)
            {
                var a = new Skrzyzowanie(2);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b3_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 3)
            {
                var a = new Skrzyzowanie(3);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b4_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 4)
            {
                var a = new Skrzyzowanie(4);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b5_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 5)
            {
                var a = new Skrzyzowanie(5);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b6_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 6)
            {
                var a = new Skrzyzowanie(6);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b7_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 7)
            {
                var a = new Skrzyzowanie(7);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b8_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 8)
            {
                var a = new Skrzyzowanie(8);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b9_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 9)
            {
                var a = new Skrzyzowanie(9);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b10_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 10)
            {
                var a = new Skrzyzowanie(10);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b11_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 11)
            {
                var a = new Skrzyzowanie(11);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b12_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 12)
            {
                var a = new Skrzyzowanie(12);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b13_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 13)
            {
                var a = new Skrzyzowanie(13);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b14_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 14)
            {
                var a = new Skrzyzowanie(14);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b15_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 15)
            {
                var a = new Skrzyzowanie(15);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b16_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 16)
            {
                var a = new Skrzyzowanie(16);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b17_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 17)
            {
                var a = new Skrzyzowanie(17);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b18_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 18)
            {
                var a = new Skrzyzowanie(18);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b19_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 19)
            {
                var a = new Skrzyzowanie(19);
                Navigation.PushModalAsync(new Page8());
            }

        }
        private void b20_Clicked(object sender, EventArgs e)
        {
            if (poziomtutaj >= 20)
            {
                var a = new Skrzyzowanie(20);
                Navigation.PushModalAsync(new Page8());
            }

        }
    }
}