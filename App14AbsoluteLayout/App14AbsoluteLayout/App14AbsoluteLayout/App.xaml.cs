using App14AbsoluteLayout.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App14AbsoluteLayout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AbsoluteDemo();
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
