using App3Sizes.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3Sizes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ClockFitSize();
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
