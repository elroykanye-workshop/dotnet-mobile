﻿using App13Bitmaps.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App13Bitmaps
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ResourceBitmapPage2();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
