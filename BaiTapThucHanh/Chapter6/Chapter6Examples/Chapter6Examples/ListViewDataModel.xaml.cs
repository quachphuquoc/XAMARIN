using Chapter6Examples.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter6Examples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewDataModel : ContentPage
    {
        public ListViewDataModel()
        {
            InitializeComponent();
            List<ListItem> ListItems = new List<ListItem>
            {
            new ListItem {Title = "First", Description="1st item"},
            new ListItem {Title = "Second", Description="2nd item"},
            new ListItem {Title = "Third", Description="3rd item"}
            };
                DataModelList.ItemsSource = ListItems;
        }

        async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Tapped", item.Title + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}