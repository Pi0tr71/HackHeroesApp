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

            InitializeComponent();

            int nr = 1;
            var grid = new Grid
            {
                ColumnSpacing = 20,
                RowSpacing = 20
            };
            var label = new Label
            {
                Text = "Pytania",
                FontSize = 30
            };
            grid.Children.Add(label, 0, 0);
            Grid.SetColumnSpan(label, 3);
            Grid.SetRow(label, 0);
            Grid.SetColumn(label, 1);

            //NavigationPage.SetHasNavigationBar(this, true);

            //int poziom = Values.Cos.Poziom;
            //b5.BackgroundColor = Color.Green;

            //for(int i = 1; i < 5; i++)
            //{
            //    for (int o = 0; o < 3; o++)
            //    {
            //        Button button = new Button
            //        {
            //            Text = nr.ToString(),
            //            CornerRadius = 10
            //        };
            //        grid.Children.Add(button,0, 0);
            //        Grid.SetRow(button, i);
            //        Grid.SetColumn(button, o);
            //    }
            //}

        }

        async void Back(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void b1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Course());
        }
    }
}