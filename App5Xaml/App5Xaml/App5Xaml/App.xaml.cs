using App5Xaml.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5Xaml
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ColorsPage();
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
