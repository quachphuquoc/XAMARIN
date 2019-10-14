using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter4Examples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LocalDesignPage());
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StaticResourcesPage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DynamicResourcePage());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExplicitStylePage());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImplicitStylePage());
        }
        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OverridingStylesPage());
        }
        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonStylesWithResourcesPage());
        }
        private void Button_Clicked_7(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new StylesPage());
        }
        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeviceStylePage());
        }
        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomDarkThemePage());
        }
        private void Button_Clicked_10(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new CSSPage());
        }
    }
}