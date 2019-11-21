using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter7Examples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(ListItem item)
        {
            InitializeComponent();

            this.BindingContext = item;
        }
    }
}