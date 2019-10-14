using BaiTap2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTap2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListviewHoa : ContentPage
    {
        ObservableCollection<Hoa> Hoas = new ObservableCollection<Hoa>();

        public PageListviewHoa()
        {
            InitializeComponent();
            Hoas.Add
                (
                    new Hoa
                    {
                        TenHoa = "Đón xuân",
                        Gia = 50000,
                        Hinh = "cuc_9.jpg",
                        MoTa = "Hoa cúc các màu: trắng, vàng, cam"
                    }
                );
            Hoas.Add
                (
                    new Hoa
                    {
                        TenHoa = "Hồn nhiên",
                        Gia = 60000,
                        Hinh = "cuc_2.jpg",
                        MoTa = "Hoa cúc vàng, cam, lá măng"
                    }
                );
            Hoas.Add
               (
                   new Hoa
                   {
                       TenHoa = "Tím thuỷ chung",
                       Gia = 45000,
                       Hinh = "cuc_3.jpg",
                       MoTa = "Hoa cúc tím"
                   }
               );

            lsvHoa.ItemsSource = Hoas;
        }
    }
}