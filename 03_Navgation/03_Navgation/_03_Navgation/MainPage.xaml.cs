﻿using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _03_Navgation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina1());
        }

        private void Button_Clicked_Modal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pagina1());
        }

        private async void Button_Clicked_PluginModal(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new Popup());
        }
    }
}
