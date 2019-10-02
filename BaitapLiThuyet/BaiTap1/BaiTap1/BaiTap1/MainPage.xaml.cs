using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BaiTap1
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

        private void OpenManHinhChao(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ManHinhChao());
        }

        private void OpenTinhTong(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ManHinhTinhTong());
        }

        private void OpenStackLayout(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayout());
        }

        private void OpenAbsoluteLayout(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayout());
        }

        private void OpenGridLayout(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calculator());
        }

        private void OpenLogin(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }
}
