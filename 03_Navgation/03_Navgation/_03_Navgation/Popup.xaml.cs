﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace _03_Navgation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Popup : Rg.Plugins.Popup.Pages.PopupPage
    {
        public Popup()
        {
            InitializeComponent();
        }
    }
}