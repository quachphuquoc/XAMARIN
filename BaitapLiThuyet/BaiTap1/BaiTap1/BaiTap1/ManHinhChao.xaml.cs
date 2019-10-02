using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTap1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManHinhChao : ContentPage
    {
        public ManHinhChao()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Lời chào", "Chào bạn " + txtHoTen.Text, "Thoát");
        }

    }
}