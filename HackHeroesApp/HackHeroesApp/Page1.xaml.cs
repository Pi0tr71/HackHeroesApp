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

        //IMyAPI myAPI;

        async void LoginPage(object sender, EventArgs e)
        {
            //myAPI = RestService.For<IMyAPI>("https://jsonplaceholder.typicode.com");
            //try
            //{
            //    PostContent post = new PostContent();
            //    post.userId = 1;
            //    PostContent result = await myAPI.SubmitPost(post);
            //    Console.WriteLine(result.id);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            //Console.WriteLine("Przycisk");
            await Navigation.PushModalAsync(new Page2());
        }

        async void RegisterPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page3());
        }
    }
}