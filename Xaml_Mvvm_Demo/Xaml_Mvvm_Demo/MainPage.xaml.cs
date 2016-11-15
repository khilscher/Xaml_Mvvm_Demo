using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xaml_Mvvm_Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnPage1ButtonClicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new Page1();
            await Navigation.PushAsync(new Page1());
        }

        async void OnPage2ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        async void OnPage3ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        async void OnPage4ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
    }
}
