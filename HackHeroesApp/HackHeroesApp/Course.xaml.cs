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
using System.Text.RegularExpressions;
using HackHeroesApp.ValuesF;

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Course : ContentPage
    {
        public Course()
        {
            InitializeComponent();
            pytania();

        }
        int lppytanie = 0;
        async void pytania()
        {
            IMyAPIQL myAPIQL;
            var authHeader = Values.Cos.Token;
            var refitSettings = new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            };
            myAPIQL = RestService.For<IMyAPIQL>(API_ENV.API_URL, refitSettings);
            QLPost post = new QLPost();
            QLPost result1 = await myAPIQL.SubmitPost(post);
            zapytanie(result1.pytania);
        }
        async void zapytanie(List<int> pytanieid)
        {
            IMyAPIQID myAPIQID;
            var authHeader = Values.Cos.Token;
            var refitSettings = new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            };
            myAPIQID = RestService.For<IMyAPIQID>(API_ENV.API_URL, refitSettings);
            QIDPost post = new QIDPost();
            post.pytanie_id = pytanieid[lppytanie].ToString();
            QIDPost result = await myAPIQID.SubmitPost(post);
            var informacje = "Punkty : " + result.pytanie.liczba_punktow + " Zakres : " + result.pytanie.zakres_struktury+ " Nr pytania : " + result.pytanie.numer_pytania;
            PZN.Text = informacje;
            PytanieText.Text = result.pytanie.pytanie;
            if(result.pytanie.odpowiedz_a == null)
            {
                Gridd = new Grid();
                var label = new Label
                {
                    Text = "Pytania",
                    FontSize = 30
                };
                Gridd.Children.Add(label, 0, 0);
                Grid.SetColumnSpan(label, 3);
                Grid.SetRow(label, 0);
                Grid.SetColumn(label, 1);
            }
        }

        //static List<string> WildcardFiles()
        //{
        //    List<string> listRange = new List<string>();
        //    listRange.Add("q");
        //    listRange.Add("s");

        //    return listRange;
        //}
        async void button4_Clicked(object sender, EventArgs e)
        {
            //zapytanie();
        }

        //private void button5_Clicked(object sender, EventArgs e)
        //{

        //}
        //static void Main(string[] args)
        //{
        //    List<string> range = WildcardFiles();
        //    foreach (string item in range)
        //    {
        //        // Do something with item
        //    }
        //}
    }
}