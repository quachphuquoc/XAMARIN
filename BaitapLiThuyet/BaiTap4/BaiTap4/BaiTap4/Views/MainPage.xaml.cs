using BaiTap4.ViewModels;
using Xamarin.Forms;

namespace BaiTap4.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            MainPageViewModel.Instance.LoadLoaiHoaList();
        }
    }
}

