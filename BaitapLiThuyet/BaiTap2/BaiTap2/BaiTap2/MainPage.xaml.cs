﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BaiTap2
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

        private void Bai1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageListviewHoa());
        }

        private void Bai2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageListviewGroup());
        }
    }
}
