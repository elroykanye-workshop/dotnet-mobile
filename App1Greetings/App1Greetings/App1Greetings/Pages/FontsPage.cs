using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1Greetings.Pages
{
    public class FontsPage : ContentPage
    {
        public FontsPage()
        {

            Content = new Label
            {
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span {
                            Text = "I ", 
                            TextColor = Color.DarkCyan,
                        },
                        new Span
                        {
                            Text = "am ",
                            TextColor = Color.DarkCyan,
                        },
                        new Span
                        {
                            Text = "Kanye!",
                            TextColor = Color.DarkGreen,
                            FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                        }
                    }
                },
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                BackgroundColor = Color.FromRgba(0.2, 0.39, 0.65, 0.35),
                FontSize = 16,
            };
        }
    }
}