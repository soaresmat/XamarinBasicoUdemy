﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace _01_Dicas_ServicoCEP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new _01_Dicas_ServicoCEP.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
