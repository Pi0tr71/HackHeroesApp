using HackHeroesApp.Services;
using HackHeroesApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackHeroesApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new Page1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
