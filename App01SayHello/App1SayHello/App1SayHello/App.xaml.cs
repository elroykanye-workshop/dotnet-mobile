using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1SayHello
{
    public partial class App : Application
    {
        public App()
        {
            /*
            InitializeComponent();

            MainPage = new MainPage();
            */

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        new Label
                        {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms"
                        }
                    }
                }
            };
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
