using App1Greetings.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Greetings
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FontNamedSizes();
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
