using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2Stack.Pages
{
    public class FramedLabel : ContentPage
    {
        public FramedLabel()
        {
            Padding = new Thickness(16);
            BackgroundColor = Color.FromRgba(0.8, 0.1, 0.54, 0.5);
            Content = new Frame
            {
                BorderColor = Color.Black,
                BackgroundColor = Color.FromRgba(0.7, 0.3, 0.6, 0.3),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = new Label
                {
                    Text = "I have been framed",
                    Padding = new Thickness(8, 4),
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    BackgroundColor = Color.FromRgba(0.75, 0.1, 0.6, 0.6),
                },
        };
        }
    }
}