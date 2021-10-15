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

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }


        async void LoginPage(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new Page2());
        }

        async void RegisterPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page3());
        }
    }
}