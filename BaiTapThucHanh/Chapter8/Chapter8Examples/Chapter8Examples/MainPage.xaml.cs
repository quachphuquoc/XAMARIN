using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter8Examples
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void ButtonClicked(object sender, EventArgs args)
        {
            DisplayAlert("Congratulations", "This button was rendered in a platform-specific class.", "OK");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new NativeViewsPage()));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new FactoryMethodsPage()));
        }
    }
}
