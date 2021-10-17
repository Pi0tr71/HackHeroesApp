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
    public partial class Page5 : ContentPage
    {
        
        public Page5()
        {
            NavigationPage.SetHasNavigationBar(this, true);
            InitializeComponent();      
            int poziom = Values.Cos.Poziom;

            switch (poziom)
            {
                case 0:
                    b1.BackgroundColor = Color.Yellow;
                    b2.BackgroundColor = Color.Red;
                    b3.BackgroundColor = Color.Red;
                    b4.BackgroundColor = Color.Red;
                    b5.BackgroundColor = Color.Red;
                    b6.BackgroundColor = Color.Red;
                    b7.BackgroundColor = Color.Red;
                    b8.BackgroundColor = Color.Red;
                    b9.BackgroundColor = Color.Red;
                    b10.BackgroundColor = Color.Red;
                    b11.BackgroundColor = Color.Red;
                    b12.BackgroundColor = Color.Red;
                    b13.BackgroundColor = Color.Red;
                    b14.BackgroundColor = Color.Red;
                    b15.BackgroundColor = Color.Red;
                    b16.BackgroundColor = Color.Red;
                    b17.BackgroundColor = Color.Red;
                    b18.BackgroundColor = Color.Red;
                    b19.BackgroundColor = Color.Red;
                    b20.BackgroundColor = Color.Red;
                    break;
                case 1:
                    b1.BackgroundColor = Color.Green;
                    b2.BackgroundColor = Color.Yellow;
                    b3.BackgroundColor = Color.Red;
                    b4.BackgroundColor = Color.Red;
                    b5.BackgroundColor = Color.Red;
                    b6.BackgroundColor = Color.Red;
                    b7.BackgroundColor = Color.Red;
                    b8.BackgroundColor = Color.Red;
                    b9.BackgroundColor = Color.Red;
                    b10.BackgroundColor = Color.Red;
                    b11.BackgroundColor = Color.Red;
                    b12.BackgroundColor = Color.Red;
                    b13.BackgroundColor = Color.Red;
                    b14.BackgroundColor = Color.Red;
                    b15.BackgroundColor = Color.Red;
                    b16.BackgroundColor = Color.Red;
                    b17.BackgroundColor = Color.Red;
                    b18.BackgroundColor = Color.Red;
                    b19.BackgroundColor = Color.Red;
                    b20.BackgroundColor = Color.Red;
                    break;
                case 2:
                    b1.BackgroundColor = Color.Green;
                    b2.BackgroundColor = Color.Green;
                    b3.BackgroundColor = Color.Yellow;
                    b4.BackgroundColor = Color.Red;
                    b5.BackgroundColor = Color.Red;
                    b6.BackgroundColor = Color.Red;
                    b7.BackgroundColor = Color.Red;
                    b8.BackgroundColor = Color.Red;
                    b9.BackgroundColor = Color.Red;
                    b10.BackgroundColor = Color.Red;
                    b11.BackgroundColor = Color.Red;
                    b12.BackgroundColor = Color.Red;
                    b13.BackgroundColor = Color.Red;
                    b14.BackgroundColor = Color.Red;
                    b15.BackgroundColor = Color.Red;
                    b16.BackgroundColor = Color.Red;
                    b17.BackgroundColor = Color.Red;
                    b18.BackgroundColor = Color.Red;
                    b19.BackgroundColor = Color.Red;
                    b20.BackgroundColor = Color.Red;
                    break;
                case 3:
                    b1.BackgroundColor = Color.Green;
                    b2.BackgroundColor = Color.Green;
                    b3.BackgroundColor = Color.Green;
                    b4.BackgroundColor = Color.Yellow;
                    b5.BackgroundColor = Color.Red;
                    b6.BackgroundColor = Color.Red;
                    b7.BackgroundColor = Color.Red;
                    b8.BackgroundColor = Color.Red;
                    b9.BackgroundColor = Color.Red;
                    b10.BackgroundColor = Color.Red;
                    b11.BackgroundColor = Color.Red;
                    b12.BackgroundColor = Color.Red;
                    b13.BackgroundColor = Color.Red;
                    b14.BackgroundColor = Color.Red;
                    b15.BackgroundColor = Color.Red;
                    b16.BackgroundColor = Color.Red;
                    b17.BackgroundColor = Color.Red;
                    b18.BackgroundColor = Color.Red;
                    b19.BackgroundColor = Color.Red;
                    b20.BackgroundColor = Color.Red;
                    break;
                case 4:
                    b1.BackgroundColor = Color.Green;
                    b2.BackgroundColor = Color.Green;
                    b3.BackgroundColor = Color.Green;
                    b4.BackgroundColor = Color.Green;
                    b5.BackgroundColor = Color.Yellow;
                    b6.BackgroundColor = Color.Red;
                    b7.BackgroundColor = Color.Red;
                    b8.BackgroundColor = Color.Red;
                    b9.BackgroundColor = Color.Red;
                    b10.BackgroundColor = Color.Red;
                    b11.BackgroundColor = Color.Red;
                    b12.BackgroundColor = Color.Red;
                    b13.BackgroundColor = Color.Red;
                    b14.BackgroundColor = Color.Red;
                    b15.BackgroundColor = Color.Red;
                    b16.BackgroundColor = Color.Red;
                    b17.BackgroundColor = Color.Red;
                    b18.BackgroundColor = Color.Red;
                    b19.BackgroundColor = Color.Red;
                    b20.BackgroundColor = Color.Red;
                    break;
                case 5:
                    b1.BackgroundColor = Color.Green;
                    b2.BackgroundColor = Color.Green;
                    b3.BackgroundColor = Color.Green;
                    b4.BackgroundColor = Color.Green;
                    b5.BackgroundColor = Color.Green;
                    b6.BackgroundColor = Color.Yellow;
                    b7.BackgroundColor = Color.Red;
                    b8.BackgroundColor = Color.Red;
                    b9.BackgroundColor = Color.Red;
                    b10.BackgroundColor = Color.Red;
                    b11.BackgroundColor = Color.Red;
                    b12.BackgroundColor = Color.Red;
                    b13.BackgroundColor = Color.Red;
                    b14.BackgroundColor = Color.Red;
                    b15.BackgroundColor = Color.Red;
                    b16.BackgroundColor = Color.Red;
                    b17.BackgroundColor = Color.Red;
                    b18.BackgroundColor = Color.Red;
                    b19.BackgroundColor = Color.Red;
                    b20.BackgroundColor = Color.Red;
                    break;
                case 6:
                    b1.BackgroundColor = Color.Green;
                    b2.BackgroundColor = Color.Green;
                    b3.BackgroundColor = Color.Green;
                    b4.BackgroundColor = Color.Green;
                    b5.BackgroundColor = Color.Green;
                    b6.BackgroundColor = Color.Green;
                    b7.BackgroundColor = Color.Yellow;
                    b8.BackgroundColor = Color.Red;
                    b9.BackgroundColor = Color.Red;
                    b10.BackgroundColor = Color.Red;
                    b11.BackgroundColor = Color.Red;
                    b12.BackgroundColor = Color.Red;
                    b13.BackgroundColor = Color.Red;
                    b14.BackgroundColor = Color.Red;
                    b15.BackgroundColor = Color.Red;
                    b16.BackgroundColor = Color.Red;
                    b17.BackgroundColor = Color.Red;
                    b18.BackgroundColor = Color.Red;
                    b19.BackgroundColor = Color.Red;
                    b20.BackgroundColor = Color.Red;
                    break;
                case 7:
                    b1.BackgroundColor = Color.Green;
                    b2.BackgroundColor = Color.Green;
                    b3.BackgroundColor = Color.Green;
                    b4.BackgroundColor = Color.Green;
                    b5.BackgroundColor = Color.Green;
                    b6.BackgroundColor = Color.Green;
                    b7.BackgroundColor = Color.Green;
                    b8.BackgroundColor = Color.Yellow;
                    b9.BackgroundColor = Color.Red;
                    b10.BackgroundColor = Color.Red;
                    b11.BackgroundColor = Color.Red;
                    b12.BackgroundColor = Color.Red;
                    b13.BackgroundColor = Color.Red;
                    b14.BackgroundColor = Color.Red;
                    b15.BackgroundColor = Color.Red;
                    b16.BackgroundColor = Color.Red;
                    b17.BackgroundColor = Color.Red;
                    b18.BackgroundColor = Color.Red;
                    b19.BackgroundColor = Color.Red;
                    b20.BackgroundColor = Color.Red;
                    break;
                case 8:
                    b1.BackgroundColor = Color.Green;
                    b2.BackgroundColor = Color.Green;
                    b3.BackgroundColor = Color.Green;
                    b4.BackgroundColor = Color.Green;
                    b5.BackgroundColor = Color.Green;
                    b6.BackgroundColor = Color.Green;
                    b7.BackgroundColor = Color.Green;
                    b8.BackgroundColor = Color.Green;
                    b9.BackgroundColor = Color.Yellow;
                    b10.BackgroundColor = Color.Red;
                    b11.BackgroundColor = Color.Red;
                    b12.BackgroundColor = Color.Red;
                    b13.BackgroundColor = Color.Red;
                    b14.BackgroundColor = Color.Red;
                    b15.BackgroundColor = Color.Red;
                    b16.BackgroundColor = Color.Red;
                    b17.BackgroundColor = Color.Red;
                    b18.BackgroundColor = Color.Red;
                    b19.BackgroundColor = Color.Red;
                    b20.BackgroundColor = Color.Red;
                    break;
                case 9:
                    b1.BackgroundColor = Color.Green;
                    b2.BackgroundColor = Color.Green;
                    b3.BackgroundColor = Color.Green;
                    b4.BackgroundColor = Color.Green;
                    b5.BackgroundColor = Color.Green;
                    b6.BackgroundColor = Color.Green;
                    b7.BackgroundColor = Color.Green;
                    b8.BackgroundColor = Color.Green;
                    b9.BackgroundColor = Color.Green;
                    b10.BackgroundColor = Color.Yellow;
                    b11.BackgroundColor = Color.Red;
                    b12.BackgroundColor = Color.Red;
                    b13.BackgroundColor = Color.Red;
                    b14.BackgroundColor = Color.Red;
                    b15.BackgroundColor = Color.Red;
                    b16.BackgroundColor = Color.Red;
                    b17.BackgroundColor = Color.Red;
                    b18.BackgroundColor = Color.Red;
                    b19.BackgroundColor = Color.Red;
                    b20.BackgroundColor = Color.Red;
                    break;
                case 10:
                    b1.BackgroundColor = Color.Green;
                    b2.BackgroundColor = Color.Green;
                    b3.BackgroundColor = Color.Green;
                    b4.BackgroundColor = Color.Green;
                    b5.BackgroundColor = Color.Green;
                    b6.BackgroundColor = Color.Green;
                    b7.BackgroundColor = Color.Green;
                    b8.BackgroundColor = Color.Green;
                    b9.BackgroundColor = Color.Green;
                    b10.BackgroundColor = Color.Green;
                    b11.BackgroundColor = Color.Yellow;
                    b12.BackgroundColor = Color.Red;
                    b13.BackgroundColor = Color.Red;
                    b14.BackgroundColor = Color.Red;
                    b15.BackgroundColor = Color.Red;
                    b16.BackgroundColor = Color.Red;
                    b17.BackgroundColor = Color.Red;
                    b18.BackgroundColor = Color.Red;
                    b19.BackgroundColor = Color.Red;
                    b20.BackgroundColor = Color.Red;
                    break;
                case 11:
                    b1.BackgroundColor = Color.Green;
                    b2.BackgroundColor = Color.Green;
                    b3.BackgroundColor = Color.Green;
                    b4.BackgroundColor = Color.Green;
                    b5.BackgroundColor = Color.Green;
                    b6.BackgroundColor = Color.Green;
                    b7.BackgroundColor = Color.Green;
                    b8.BackgroundColor = Color.Green;
                    b9.BackgroundColor = Color.Green;
                    b10.BackgroundColor = Color.Green;
                    b11.BackgroundColor = Color.Green;
                    b12.BackgroundColor = Color.Yellow;
                    b13.BackgroundColor = Color.Red;
                    b14.BackgroundColor = Color.Red;
                    b15.BackgroundColor = Color.Red;
                    b16.BackgroundColor = Color.Red;
                    b17.BackgroundColor = Color.Red;
                    b18.BackgroundColor = Color.Red;
                    b19.BackgroundColor = Color.Red;
                    b20.BackgroundColor = Color.Red;
                    break;
                case 12:
                    b1.BackgroundColor = Color.Green;
                    b2.BackgroundColor = Color.Green;
                    b3.BackgroundColor = Color.Green;
                    b4.BackgroundColor = Color.Green;
                    b5.BackgroundColor = Color.Green;
                    b6.BackgroundColor = Color.Green;
                    b7.BackgroundColor = Color.Green;
                    b8.BackgroundColor = Color.Green;
                    b9.BackgroundColor = Color.Green;
                    b10.BackgroundColor = Color.Green;
                    b11.BackgroundColor = Color.Green;
                    b12.BackgroundColor = Color.Green;
                    b13.BackgroundColor = Color.Yellow;
                    b14.BackgroundColor = Color.Red;
                    b15.BackgroundColor = Color.Red;
                    b16.BackgroundColor = Color.Red;
                    b17.BackgroundColor = Color.Red;
                    b18.BackgroundColor = Color.Red;
                    b19.BackgroundColor = Color.Red;
                    b20.BackgroundColor = Color.Red;
                    break;

            }
            

        }

        async void Back(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}