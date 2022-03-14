using App12Styles.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12Styles
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ColoredButtonsPage();
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
