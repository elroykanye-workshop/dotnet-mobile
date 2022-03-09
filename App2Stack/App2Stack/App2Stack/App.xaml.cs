using App2Stack.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2Stack
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ColorBoxes();
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
