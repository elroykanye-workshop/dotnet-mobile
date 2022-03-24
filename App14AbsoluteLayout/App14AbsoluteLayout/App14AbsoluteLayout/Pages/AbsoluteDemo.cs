using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App14AbsoluteLayout.Pages
{
    public class AbsoluteDemo : ContentPage
    {
        public AbsoluteDemo()
        {

            AbsoluteLayout absoluteLayout = new AbsoluteLayout
            {
                Padding = new Thickness(48),
            };
            absoluteLayout.Children.Add(new BoxView
            {
                Color = Color.Accent,
            }, new Rectangle(0, 10, 200, 5));
            absoluteLayout.Children.Add(new BoxView
            {
                Color = Color.Accent,
            }, new Rectangle(0, 10, 200, 5));
            absoluteLayout.Children.Add(new BoxView
            {
                Color = Color.Accent,
            }, new Rectangle(10, 0, 5, 65));
            absoluteLayout.Children.Add(new BoxView
            {
                Color = Color.Accent,
            }, new Rectangle(10, 0, 5, 65));

            absoluteLayout.Children.Add(new Label
            {
                Text = "Stylish Header",
                FontSize = 24,
            }, new Point(30, 25));
            absoluteLayout.Children.Add(new Label
            {
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                            Text = "Although the ",
                        },
                        new Span
                        {
                            Text = "AbsoluteLayout",
                            FontAttributes = FontAttributes.Italic,
                        },
                        new Span
                        {
                            Text = " is usually employed for purposes other" +
                            " than the dislay of text using "
                        }, new Span
                        {
                            Text = "Label",
                            FontAttributes = FontAttributes.Italic,
                        },
                        new Span
                        {
                            Text = ", obviously it can be used in that way. " +
                            "The text continues to wrap nicely " +
                            "within the bounds of the container" +
                            " and any padding that may be applied."
                        }
                    }
                }
            }, new Point(0, 80));



            Content = absoluteLayout;
        }
    }
}