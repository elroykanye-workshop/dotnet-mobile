using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1Greetings.Pages
{
    public class ColorsPage : ContentPage
    {
        public ColorsPage()
        {
            Content = new Label
            {
                Text = "Hello Vince, Welcome to Xamarin.Forms!",
                BackgroundColor = Color.FromRgba(0.3, 1, 0.4, 0.4),
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
               

            };
        }
    }
}