using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter2Examples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenArrayPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArrayPage());
        }
        private void OpenReferencePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReferencePage());
        }
        private void OpenConstructorsPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConstructorsPage());
        }
        private void OpenPropertyValuesPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PropertyValuesPage());
        }
    }
}