using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackHeroesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : TabbedPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        async void KursT(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page5());
        }
    }
}