using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2Stack.Pages
{
    public class ColorBoxes : ContentPage
    {
        public ColorBoxes()
        {
            var colorStack = new StackLayout();
            Dictionary<string, object> colors = typeof(Color)
                .GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                .Where(f => f.FieldType == typeof(Color))
                .ToDictionary(f => f.Name, f => f.GetValue(null));

            foreach (var color in colors)
            {
                colorStack.Children.Add(CreateColorView((Color)color.Value, color.Key));
            };


            Content = new StackLayout
            {
                Children =
               {
                   new Label
                   {
                       HorizontalTextAlignment = TextAlignment.Center,
                       VerticalTextAlignment = TextAlignment.Center,
                       Text = "Colors Stack"
                   },
                   new ScrollView
                   {
                       Content = colorStack,
                   }
               }
            };
        }

        public View CreateColorView(Color color, string name)
        {

            return new Frame
            {
                Padding = new Thickness(4, 2),
                Content = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 16,
                    Children =
                    {
                        new BoxView
                        {
                            BackgroundColor = color,
                            HeightRequest = 32,
                            WidthRequest = 32,
                        },
                        new Label
                        {
                            Text = name,
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            HorizontalOptions = LayoutOptions.StartAndExpand,
                        },
                        new StackLayout
                        {
                            HorizontalOptions = LayoutOptions.End,
                            Children =
                            {
                                new Label
                                {
                                    Text = String.Format("Lum: {0:F2} - Hue: {1:F2} - Sat: {2:F2}", color.Luminosity, color.Hue, color.Saturation),
                                    HorizontalTextAlignment = TextAlignment.End,
                                    HorizontalOptions = LayoutOptions.End,
                                    FontAttributes = FontAttributes.Italic,
                                },
                                new Label
                                {
                                    Text = String.Format("R: {0:F0} - G: {1:F0} - B: {2:F0}", color.R * 255, color.G * 255, color.B * 255),
                                    HorizontalTextAlignment = TextAlignment.End,
                                    HorizontalOptions = LayoutOptions.End,
                                    FontAttributes = FontAttributes.Italic,
                                }
                            }
                        } 
                    } 
                },
            };
        }
    }
}