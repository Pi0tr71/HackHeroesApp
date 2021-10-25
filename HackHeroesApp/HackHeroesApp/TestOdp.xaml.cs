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
        int pkt = TestWynik.Cos.Pkt;
        public TestOdp()
        {
            InitializeComponent();
            if(pkt >= 68)
            {
                Console.WriteLine("Zdałeś gratualcje");
            }
            LabelText.Text = "Zdobyłeś " + pkt + "/72";
        }
    }
}