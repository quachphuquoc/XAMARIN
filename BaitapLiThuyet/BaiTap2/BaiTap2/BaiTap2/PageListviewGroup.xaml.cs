using BaiTap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTap2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListviewGroup : ContentPage
    {
        public PageListviewGroup()
        {
            InitializeComponent();

            LoaiHoa l = new LoaiHoa();
            lstHoa.ItemsSource = l.Loaihoas;
        }
    }
}