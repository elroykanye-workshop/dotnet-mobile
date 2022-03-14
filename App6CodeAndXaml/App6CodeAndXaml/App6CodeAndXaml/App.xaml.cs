using App6CodeAndXaml.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

#if __iOS__
using UIKit;
#endif

namespace App6CodeAndXaml
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new MonkeyTap();
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
