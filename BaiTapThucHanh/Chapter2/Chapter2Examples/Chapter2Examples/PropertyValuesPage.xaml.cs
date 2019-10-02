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
    public partial class PropertyValuesPage : ContentPage
    {
        public PropertyValuesPage()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {

        }
    }
}