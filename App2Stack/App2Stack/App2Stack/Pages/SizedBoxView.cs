using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2Stack.Pages
{
    public class SizedBoxView : ContentPage
    {
        public SizedBoxView()
        {
            BackgroundColor = Color.LightCyan;
            Content = new BoxView
            {
                Color = Color.Accent,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 200,
                HeightRequest = 100,
            };
        }
    }
}