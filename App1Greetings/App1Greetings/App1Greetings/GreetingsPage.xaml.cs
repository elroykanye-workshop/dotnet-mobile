using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Greetings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetingsPage : ContentPage
    {
        public GreetingsPage()

        {
            this.Content = new Label
            {
                Text = "Greetings, Xamarin.Forms!",
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            this.Content = new Label
            {
                Text = "My name is Elroy Kanye, Software Developer",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
            };

            switch(Device.RuntimePlatform)
            {
                case Device.iOS:
                    this.Padding = new Thickness(0, 20, 0, 0);
                    break;
                default:
                    this.Padding = new Thickness(0,0, 0, 0);
                    break;
            }


            this.Padding = new Thickness(0, 20, 0, 20);

        }
    }
}