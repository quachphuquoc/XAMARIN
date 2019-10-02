using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter1Examples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentPageExample : ContentPage
    {
        public ContentPageExample()
        {
            InitializeComponent();
        }
        protected void ButtonClicked(object sender, EventArgs e)
        {
            ((Button)sender).Text = "It is so!";
        }
        async protected void ImageTapped(object sender, EventArgs e)
        {
            Image image = ((Image)sender);
            image.Opacity = .5;
            await Task.Delay(200);
            image.Opacity = 1;
        }
    }
}